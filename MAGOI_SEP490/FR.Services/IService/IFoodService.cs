using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types.InputTypes;

namespace FR.Services.IService
{
    public interface IFoodService
    {
        IQueryable<Food> GetFoods();
        IQueryable<Food> GetFoodsByCategory(int categoryId);
        Task<Food> GetFoodById(int id);
        Task UpdateFoodQuantityWhenCreateOrder(List<FoodOrderInput> foodListInput);
        Task<Food> AddFood(AddFoodInput food);
        Task<Food> UpdateFood(UpdateFoodInput food);
        Task<bool> CheckFoodOrdersQuantity(List<FoodOrderInput> foodListInput);
    }
}
