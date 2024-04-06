using System.Reflection.Metadata.Ecma335;
using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;
using FR.Services.IService;
namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<FoodCategory> GetCategories(IFoodCategoryService service) => service.GetFoodCategories();
        public List<FoodOrderCategory> GetFoodOrderCategories(IFoodCategoryService service) => service.GetFoodOrderCategories();
    }
}
