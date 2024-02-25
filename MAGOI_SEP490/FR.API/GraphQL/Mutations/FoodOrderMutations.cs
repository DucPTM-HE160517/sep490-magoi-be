using FR.BusinessObjects.Models.ExpoNotification;
using FR.Services.IService;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async Task<string> UpdateFoodOrderStatusAsync(
            ISessionService sessionService,
            IExpoNotificationService expoSdkClient)
        {
            //get list of waiter devices
            List<string> waiterTokens = sessionService.GetExpoTokensByRoleId("waiter");

            //create notification
            var pushTicketReq = new PushTicketRequest()
            {
                PushTo = waiterTokens,

                //TODO: change table name and order number to appropriate value
                PushTitle = $"Table {1} - Order {"FR1234"}",
                PushBody = "There is a done food! Please serve the food to the customer!",
            };

            //send notification to expo server
            var result = await expoSdkClient.PushSendAsync(pushTicketReq);

            //handle error
            if (result?.PushTicketErrors?.Count() > 0)
            {
                foreach (var error in result.PushTicketErrors)
                {
                    Console.WriteLine($"Error: {error.ErrorCode} - {error.ErrorMessage}");
                }
            }

            return "Notification sent!";
        }
    }
}
