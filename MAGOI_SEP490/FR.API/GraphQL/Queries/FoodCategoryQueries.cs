using FR.BusinessObjects.Models;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public async Task<List<FoodCategory>> GetCategories(IFoodCategoryService service) => await service.GetFoodCategories().ToListAsync();
    }
}
