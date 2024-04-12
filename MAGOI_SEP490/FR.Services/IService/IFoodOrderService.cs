using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;
using FR.Services.GraphQL.Types.InputTypes;

namespace FR.Services.IService
{
    public interface IFoodOrderService
    {
        Task<List<FoodOrder>> AddFoodOrdersAsync(Guid orderId, List<FoodOrderInput> foodOrders);
        Task<List<FoodOrder>> GetFoodOrdersByOrderIdAsync(Guid orderId);
        Task UpdateFoodOrdersStatusAsync(Guid orderId, int foodOrderStatusId);
        Task<FoodOrder> UpdateFoodOrderStatusAsync(Guid orderId, int foodId, int foodOrderStatusId);
        Task<Food[]> GetTop5FoodOfOrdersAsync(List<Order> orders);
        Task<SaleReport> GetSaleReportAsync(DateTime startDate, DateTime endDate);
        Task<List<Food>> GetCookingFoodsByCategoryAsync(int id);
    }
}
