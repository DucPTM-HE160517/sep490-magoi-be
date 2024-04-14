using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public async Task<IEnumerable<Food>> GetFoods(IFoodService service) => await service.GetFoods();
        public async Task<Food> GetFood(IFoodService service, int ID) => await service.GetFoodById(ID);
    }
}
