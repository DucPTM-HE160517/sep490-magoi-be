using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types.InputTypes;
using Microsoft.EntityFrameworkCore.Query;

namespace FR.Services.IService
{
    public interface IFoodService
    {
        Task<List<Food>> GetFoodsAsync();
        Task<List<Food>> GetFoodsByCategoryAsync(int categoryId);
        Task<Food> GetFoodByIdAsync(int id);
        Task UpdateFoodQuantityWhenCreateOrderAsync(List<FoodOrderInput> foodListInput);
        Task<Food> AddFoodAsync(AddFoodInput food);
        Task<Food> UpdateFoodAsync(UpdateFoodInput food);
        Task<bool> CheckFoodOrdersQuantityAsync(List<FoodOrderInput> foodListInput);
    }
}
