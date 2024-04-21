using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public IQueryable<FoodCategory> GetCategories(IFoodCategoryService service) 
            => service.GetFoodCategories();
    }
}
