using System.Reflection.Metadata.Ecma335;
using FR.BusinessObjects.Models;
using FR.Services.IService;
namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public async List<FoodCategory> GetCategories(IFoodCategoryService service) => await service.GetFoodCategories().ToListAsync();
    }
}
