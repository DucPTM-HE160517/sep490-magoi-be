using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<FoodOrder> GetFoodOrdersByOrderId(IFoodOrderService service, Guid orderId) => service.GetFoodOrdersByOrderId(orderId);
    }
}
