using FR.BusinessObjects.Models.ExpoNotification;
﻿using FR.API.GraphQL.Payload;
using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        //update food in the order: cooking to cooked
        public async Task<UpdateFoodOrderStatusPayload> UpdateFoodOrderStatusAsync(
            Guid orderId, int foodId,
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
                //get list of waiter devices
                List<string> waiterTokens = sessionService.GetExpoTokensByRoleId("waiter");
                //update food status in the order
                FoodOrder food = foodOrderService.UpdateFinishedFoodOrderStatus(orderId, foodId);

                await expoSdkClient.SendNotification(waiterTokens,
                    $"{table.Name} - Order {orderId}",
                    "There is a done food! Please serve the food to the customer!");
                return new UpdateFoodOrderStatusPayload(food);
            }
            catch(Exception e)
            {
                return new UpdateFoodOrderStatusPayload((new UserError("ERROR: " + e.Message, "ERROR_CODE")));
            }
        }
    }
}
