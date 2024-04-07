using FR.BusinessObjects.Models;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public IQueryable<Food> GetFoods(IFoodService service) => service.GetFoods();
        public Food GetFood(IFoodService service, int ID) => service.GetFoodById(ID).Result;
    }
}
