using FR.API.GraphQL.Payload;
using FR.BusinessObjects.Models;
using FR.BusinessObjects.Models.ExpoNotification;
using FR.Services.GraphQL.InputTypes;
using FR.Services.IService;
using FR.Services.Service;
using HotChocolate.Subscriptions;

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
                return new AddOrderPayload(new UserError("ERROR: Please check the food quantity!", "FOOD_AMOUNT_EXCEED"));
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

        public async Task<string> UpdateOrderStatusAsync(
            ISessionService sessionService,
            IExpoNotificationService expoSdkClient)
        {
            /*
             * 1. Chef will update the order status to "done" or update the food status to "done" (❌)
             * 2. Send notification to waiter (✅)
             */

            //get list of waiter devices
            List<string> waiterTokens = sessionService.GetExpoTokensByRoleId("waiter");

            await expoSdkClient.SendNotification(waiterTokens, 
                $"Table {1} - Order {"FR1234"}", 
                "There is a done food! Please serve the food to the customer!");
           
            return "Notification sent!";
        }
    }
}