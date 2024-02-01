using FR.BusinessObjects.Models;
using FR.Services.GraphQL.InputTypes;

namespace FR.Services.IService
{
    public interface IFoodService
    {
        List<Food> GetFoods();
        List<Food> GetFoodsByCategory(int categoryId);
        Food GetFoodById(int id);
        void UpdateFoodQuantityWhenCreateOrder(List<FoodOrderInput> foodListInput);
        bool CheckFoodOrdersQuantity(List<FoodOrderInput> foodListInput);
    }
}
