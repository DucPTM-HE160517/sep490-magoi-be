using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Queries
{
    public class FoodQueries
    {
        private DBContext dbContext = new DBContext();

        public IQueryable<Food> GetFoods() =>
            dbContext.Foods;


    }
}
