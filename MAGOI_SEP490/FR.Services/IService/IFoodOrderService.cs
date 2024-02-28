using FR.BusinessObjects.Models;
using FR.Services.GraphQL.InputTypes;

namespace FR.Services.IService
{
    public interface IFoodOrderService
    {
        List<FoodOrder> AddFoodOrders(Guid orderId, List<FoodOrderInput> foodOrders);
        List<FoodOrder> GetFoodOrdersByOrderId(Guid orderId);
        void UpdateFoodOrdersStatus(Guid orderId, int foodOrderStatusId);
        FoodOrder UpdateFoodOrderStatus(Guid orderId, int foodId, int foodOrderStatusId);
    }
}
