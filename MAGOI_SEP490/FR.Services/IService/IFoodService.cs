using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types.InputTypes;
using Microsoft.EntityFrameworkCore.Query;

namespace FR.Services.IService
{
    public interface IFoodService
    {
        List<Food> GetFoods(bool? foodStatus);
        List<Food> GetFoodsByCategory(int categoryId);
        Food GetFoodById(int id);
        void UpdateFoodQuantityWhenCreateOrder(List<FoodOrderInput> foodListInput);
        Food AddFood(AddFoodInput food);
        Food UpdateFood(UpdateFoodInput food);
        bool CheckFoodOrdersQuantity(List<FoodOrderInput> foodListInput);
        bool CheckFoodExistFoodOrder(int id);
    }
}
