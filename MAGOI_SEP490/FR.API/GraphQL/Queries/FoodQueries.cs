using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.IService;
using FR.Services.Service;

namespace FR.API.GraphQL.Queries
{
    public class FoodQueries
    {
        //private readonly IFoodService _foodService;
        //public FoodQueries(IFoodService foodService)
        //{
        //    _foodService = foodService;
        //}

        public List<Food> GetFoods(IFoodService service)
        {
            return service.GetFoods();
        }
        public List<FoodCategory> GetFoodCategorys(IFoodService service)
        {
            return service.GetFoods1();
        }

        public Food GetFood(IFoodService service, int id)
        {
            return service.GetFood(id);
        }
    }
}
