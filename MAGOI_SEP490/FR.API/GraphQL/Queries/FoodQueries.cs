using FR.BusinessObjects.Models;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<Food> GetFoods(IFoodService service) => service.GetFoods().ToList();
        public async Task<Food> GetFood(IFoodService service, int ID) => await service.GetFoodById(ID);
    }
}
