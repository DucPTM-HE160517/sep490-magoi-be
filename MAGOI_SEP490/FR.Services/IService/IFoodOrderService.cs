using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;
using FR.Services.GraphQL.Types.InputTypes;

namespace FR.Services.IService
{
    public interface IFoodOrderService
    {
        List<FoodOrder> AddFoodOrders(Guid orderId, List<FoodOrderInput> foodOrders);
        List<FoodOrder> GetFoodOrdersByOrderId(Guid orderId);
        void UpdateFoodOrdersStatus(Guid orderId, int foodOrderStatusId);
        FoodOrder UpdateFoodOrderStatus(Guid orderId, int foodId, int foodOrderStatusId);
        Food[] GetTop5FoodOfOrders(List<Order> orders);
        SaleReport GetSaleReport(DateTime startDate, DateTime endDate);
        IQueryable<Food> GetCookingFoodsByCategory(int id);
    }
}
