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
                string foodName = foodService.GetFoodById(foodId).Name;
                if (sendNotification.HasValue && (bool)sendNotification)
                {
                    //get list of waiter devices
                    List<string> waiterTokens = sessionService.GetExpoTokensByRoleId("waiter");
                    //send notification 
                    string msg = food.FoodOrderStatusId == (int)FoodOrderStatusId.Cooked ?
                        "Có món đã làm xong! Hãy phục vụ cho khách hàng!"
                        : $"Món {foodName} đã được cập nhật sang trạng thái {Enum.GetName(typeof(FoodOrderStatusId), (FoodOrderStatusId)food.FoodOrderStatusId)}!";
                    
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
