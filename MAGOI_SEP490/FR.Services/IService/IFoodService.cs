using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types.InputTypes;
using Microsoft.EntityFrameworkCore.Query;

namespace FR.Services.IService
{
    public interface IFoodService
    {
        Task<IEnumerable<Food>> GetFoods();
        IQueryable<Food> GetFoodsByCategory(int categoryId);
        Task<Food> GetFoodById(int id);
        Task<Food> AddFood(AddFoodInput food);
        Task<Food> UpdateFood(UpdateFoodInput food);
        Task<bool> CheckFoodOrdersQuantity(List<FoodOrderInput> foodListInput);
    }
}
