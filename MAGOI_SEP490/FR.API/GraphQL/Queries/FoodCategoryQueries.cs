using System.Reflection.Metadata.Ecma335;
using FR.BusinessObjects.Models;
using FR.Services.IService;
namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<FoodCategory> GetCategories(IFoodCategoryService service) => service.GetFoodCategories();
    }
}
