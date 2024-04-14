using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async Task<FoodOrder> UpdateFoodOrderStatus(
            IFoodOrderService foodOrderService, IExpoNotificationService expoSdkClient,
            Guid orderId, int foodId, int statusId, bool sendNotification = false)
            => await foodOrderService.UpdateFoodOrderStatus(expoSdkClient,
            orderId, foodId, statusId, sendNotification);
    }
}
