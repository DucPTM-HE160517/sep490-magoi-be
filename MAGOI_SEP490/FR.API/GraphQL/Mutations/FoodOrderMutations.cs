using FR.BusinessObjects.Models;
using FR.Services.IService;
using Newtonsoft.Json;
using FR.Services.GraphQL.Payload;
using FR.Infrastructure.Enums;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        //update food in the order: cooking to cooked
        public async Task<UpdateFoodOrderStatusPayload> UpdateFoodOrderStatusAsync(
            Guid orderId, int foodId, int statusId, bool? sendNotification,
            IFoodService foodService,
            IFoodOrderService foodOrderService,
            IOrderService orderService,
            ITableService tableService,
            ISessionService sessionService,
            IExpoNotificationService expoSdkClient)
        {
            try
            {
                //Get order and table
                Order order = orderService.GetOrderById(orderId);
                Table table = tableService.GetTable(order.TableId);
                //update food status in the order
                FoodOrder food = foodOrderService.UpdateFoodOrderStatus(orderId, foodId, statusId);

                //check if all foods in the order are cooked
                List<FoodOrder> foodOrders = foodOrderService.GetFoodOrdersByOrderId(orderId);
                bool allFoodsCooked = true;
                foreach (var f in foodOrders)
                {
                    if (f.FoodOrderStatusId != (int)FoodOrderStatusId.Cooked)
                    {
                        allFoodsCooked = false;
                        break;
                    }
                }

                if (sendNotification.HasValue && (bool)sendNotification)
                {
                    //get list of waiter devices
                    List<string> waiterTokens = sessionService.GetExpoTokensByRoleId("waiter");
                    //send notification
                    string msg = "Có món đã làm xong! Hãy phục vụ cho khách hàng!";

                    if (allFoodsCooked)
                    {
                        orderService.UpdateOrderStatus(orderId, (int)OrderStatusId.Serving);
                        msg = "Đơn hàng đã làm xong! Hãy phục vụ cho khách hàng!";
                    }

                    await expoSdkClient.SendNotification(waiterTokens,
                        $"{table.Name} - Đơn #FR{orderId.ToString().Substring(0,5).ToUpper()}", msg,
                        data: JsonConvert.SerializeObject(new
                        {
                            type = NotificationType.FoodReady,
                            tableId = table.Id,
                        }));
                }

                return new UpdateFoodOrderStatusPayload(food);
            }
            catch(Exception e)
            {
                return new UpdateFoodOrderStatusPayload((new UserError("ERROR: " + e.Message, "ERROR_CODE")));
            }
        }
    }
}
