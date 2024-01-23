using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.IService;
using FR.Services.Service;

namespace FR.API.GraphQL.Queries
{
    public class FoodQueries
    {
        private readonly DBContext dbContext = new DBContext();
        //private readonly IFoodService _foodService;
        //private readonly FoodDAO fd;
        //public FoodQueries(FoodDAO foodDAO)
        //{
        //    fd = foodDAO;
        //}

        public List<Food> GetFoods() => dbContext.Foods.ToList();
    }
}
