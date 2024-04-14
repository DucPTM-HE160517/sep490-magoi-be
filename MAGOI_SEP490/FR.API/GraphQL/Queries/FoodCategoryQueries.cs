using FR.BusinessObjects.Models;
using FR.Services.IService;
namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public async Task<IEnumerable<FoodCategory>> GetCategories(IFoodCategoryService service) => await service.GetFoodCategories();
    }
}
