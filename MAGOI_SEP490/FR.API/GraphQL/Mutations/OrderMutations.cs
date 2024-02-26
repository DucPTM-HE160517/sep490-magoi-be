using FR.API.GraphQL.Payload;
using FR.BusinessObjects.Models;
using FR.Services.GraphQL.InputTypes;
using FR.Services.IService;
using HotChocolate.Subscriptions;
using Newtonsoft.Json;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async Task<AddOrderPayload> AddOrder(
            [Service] ITopicEventSender eventSender,
            IOrderService orderService, IFoodOrderService foodOrderService,
            ITableService tableService, IFoodService foodService,
            OrderInput orderInput,
            List<FoodOrderInput> foodListInput, CancellationToken cancellationToken)
        {
            //check order: foods amount exceed food quantity
            if (!foodService.CheckFoodOrdersQuantity(foodListInput))
            {
                return new AddOrderPayload(
                    new UserError("ERROR: Please check the food quantity!", "FOOD_AMOUNT_EXCEED"));
            }

            //add order
            Order order;
            try
            {
                order = orderService.AddOrder(orderInput);
            }
            catch (Exception ex)
            {
                return new AddOrderPayload(new UserError("ERROR: " + ex.Message, "ERROR_CODE"));
            }

            //add food order
            try
            {
                List<FoodOrder> foodOrders = foodOrderService.AddFoodOrders(order.Id, foodListInput);
                //update the quantity of the food
                foodService.UpdateFoodQuantityWhenCreateOrder(foodListInput);
                //update table status to serving
                tableService.UpdateTableStatusWhenCreateOrder(orderInput.tableId);

                await eventSender.SendAsync(nameof(AddOrder), order, cancellationToken);

                return new AddOrderPayload(order, foodOrders);
            }
            catch (Exception ex)
            {
                //delete order -> not done
                return new AddOrderPayload(new UserError("ERROR: " + ex.Message, "ERROR_CODE"));
            }
        }

        //update order status from in progress to finished
        public async Task<UpdateOrderStatusPayload> UpdateOrderStatusAsync(
            Guid orderId,
            IOrderService orderService,
            ITableService tableService,
            ISessionService sessionService,
            IExpoNotificationService expoSdkClient)
        {
            /*
             * 1. Chef will update the order status to "done" or update the food status to "done" (❌)
             * 2. Send notification to waiter (✅)
             */
            //Get order and table
            Order order = orderService.GetOrderById(orderId);
            Table table = tableService.GetTable(order.TableId);

            try
            {
                //Update order status
                orderService.UpdateFinishedOrderStatus(orderId);
                //get list of waiter devices
                List<string> waiterTokens = sessionService.GetExpoTokensByRoleId("waiter");

                await expoSdkClient.SendNotification(waiterTokens,
                    $"{table.Name} - Order {orderId}",
                    "There is a done order! Please serve the food to the customer!",
                    data: JsonConvert.SerializeObject(new
                    {
                        type = NotificationType.FoodReady
                    }));

                return new UpdateOrderStatusPayload(order);
            }
            catch (Exception e)
            {
                return new UpdateOrderStatusPayload(new UserError("ERROR: " + e.Message, "ERROR_CODE"));
            }
        }

        //finish all orders of the table and return bill
        public async Task<FinishOrderPayload> FinishOrders(Guid tableId, DateTime finishedAt,
            IOrderService orderService,
            ITableService tableService,
            IFoodOrderService foodOrderService,
            IBillService billService)
        {
            try
            {
                List<Order> orders = new List<Order>();

                // get served orders by tableId 
                orders = orderService.GetServedOrdersByTableId(tableId);

                // update order status to "finished"
                foreach (var order in orders)
                {
                    orderService.UpdateFinishedOrderStatus(order.Id);
                }

                //update food status in the order to "cooked"
                foreach (var order in orders)
                {
                    foodOrderService.UpdateFinishedFoodOrdersStatus(order.Id);
                }

                // update table status to "available"
                tableService.UpdateTableStatus(orders[0].TableId, TableStatusId.Available);
                Bill bill = billService.CreateBill(orderService.GetTotalPriceOfOrders(orders));


                foreach (var order in orders)
                {
                    orderService.UpdateBillIdOfOrder(order.Id, bill.Id);
                }

                // update finished time of the bill
                billService.UpdateBillFinishedTime(bill, finishedAt);

                return new FinishOrderPayload(orders, bill);
            }
            catch (Exception e)
            {
                return new FinishOrderPayload(new UserError("ERROR: " + e.Message, "ERROR_CODE"));
            }
        }
    }
}