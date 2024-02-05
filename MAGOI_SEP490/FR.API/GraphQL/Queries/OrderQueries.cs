using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<Order> GetOrdersByStatusID(IOrderService service,int? statusID) => service.GetOrdersByOrderStatusId(statusID);

        public List<FoodOrder> GetFoodOrdersByOrderId (IFoodOrderService service, Guid orderId) => service.GetFoodOrdersByOrderId(orderId);
    }
}
