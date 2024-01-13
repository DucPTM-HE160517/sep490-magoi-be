using HotChocolate.Authorization;
using MAGOI.BusinessObjects.DataContext;
using MAGOI.BusinessObjects.Models;

namespace MAGOI.API.GraphQL.Queries
{
    public class FoodQueries
    {
        private DBContext dbContext = new DBContext();

        public IQueryable<Food> GetFoods() =>
            dbContext.Foods;

        public Food GetFoodByID(int id) =>
            dbContext.Foods.SingleOrDefault(f => f.Id == id);


    }
}
