using FR.BusinessObjects.Models.ExpoNotification;
﻿using FR.API.GraphQL.Payload;
using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async Task<String> SendFoodOrderNotificationAsync(
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
            //get list of waiter devices
            List<string> waiterTokens = sessionService.GetExpoTokensByRoleId("waiter");

            await expoSdkClient.SendNotification(waiterTokens,
                $"{table.Name} - Order {orderId}",
                "There is a done food! Please serve the food to the customer!");

            return "Notification sent!";
        }
    }
}
