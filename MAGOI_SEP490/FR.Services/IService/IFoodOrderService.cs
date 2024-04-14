using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types.InputTypes;

namespace FR.Services.IService
{
    public interface IFoodOrderService
    {
        Task<List<FoodOrder>> AddFoodOrders(Guid orderId, List<FoodOrderInput> foodOrders);
        IQueryable<FoodOrder> GetFoodOrdersByOrderId(Guid orderId);
        Task<FoodOrder> UpdateFoodOrderStatus(IExpoNotificationService expoSdkClient,
            Guid orderId, int foodId, int foodOrderStatusId, bool sendNotification);
        Task<Food[]> GetTop5FoodOfOrders(List<Order> orders);
        Task<List<Food>> GetCookingFoodsByCategory(int id);
    }
}
