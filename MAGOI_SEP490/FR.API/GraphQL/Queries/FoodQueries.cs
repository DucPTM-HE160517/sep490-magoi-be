using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<Food> GetFoods(IFoodService service, bool IsActive = true) => service.GetFoods(IsActive);
        public Food GetFood(IFoodService service, int ID) => service.GetFoodById(ID);
    }
}
