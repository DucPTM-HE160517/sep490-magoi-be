using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.IService;
using FR.Services.Service;

namespace FR.API.GraphQL.Queries
{
    public class FoodQueries
    {
        public List<Food> GetFoods(IFoodService service) => service.GetFoods();
    }
}
