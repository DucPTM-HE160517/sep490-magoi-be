using FR.BusinessObjects.Models;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public async Task<List<Food>> GetFoods(IFoodService service) => await service.GetFoods().ToListAsync();
        public async Task<Food> GetFood(IFoodService service, int ID) => await service.GetFoodById(ID);
    }
}
