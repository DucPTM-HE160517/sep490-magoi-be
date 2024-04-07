using FR.BusinessObjects.Models;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public async Task<List<FoodOrder>> GetFoodOrdersByOrderId(IFoodOrderService service, Guid orderId) => await service.GetFoodOrdersByOrderId(orderId).ToListAsync();
    }
}
