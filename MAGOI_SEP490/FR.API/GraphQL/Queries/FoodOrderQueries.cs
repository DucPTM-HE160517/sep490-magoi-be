using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public IQueryable<FoodOrder> GetFoodOrdersByOrderId(IFoodOrderService service, Guid orderId) 
            => service.GetFoodOrdersByOrderId(orderId);

        public async Task<IEnumerable<FoodCategory>> GetCookingFoodByCategory(IFoodCategoryService service) 
            => await service.GetCategoryOfCookingFoods();
    }
}
