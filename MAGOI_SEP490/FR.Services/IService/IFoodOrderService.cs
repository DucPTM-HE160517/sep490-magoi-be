using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;
using FR.Services.GraphQL.Types.InputTypes;

namespace FR.Services.IService
{
    public interface IFoodOrderService
    {
        Task<List<FoodOrder>> AddFoodOrders(Guid orderId, List<FoodOrderInput> foodOrders);
        IQueryable<FoodOrder> GetFoodOrdersByOrderId(Guid orderId);
        Task UpdateFoodOrdersStatus(Guid orderId, int foodOrderStatusId);
        Task<FoodOrder> UpdateFoodOrderStatus(Guid orderId, int foodId, int foodOrderStatusId);
        Task<Food[]> GetTop5FoodOfOrders(List<Order> orders);
        Task<SaleReport> GetSaleReport(DateTime startDate, DateTime endDate);
        Task<List<Food>> GetCookingFoodsByCategory(int id);
    }
}
