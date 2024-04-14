using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface IFoodCategoryService
    {
        Task<IEnumerable<FoodCategory>> GetCategoryOfCookingFoods();
        Task<IEnumerable<FoodCategory>> GetFoodCategories();
        Task<FoodCategory> GetFoodCategoryById(int id);
    }
}
