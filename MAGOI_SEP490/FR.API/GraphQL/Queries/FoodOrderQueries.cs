using FR.BusinessObjects.Models;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public IQueryable<FoodOrder> GetFoodOrdersByOrderId(IFoodOrderService service, Guid orderId) =>  service.GetFoodOrdersByOrderId(orderId);
    }
}
