using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface IFoodCategoryService
    {
        Task<List<FoodCategory>> GetCategoryOfCookingFoodsAsync();
        Task<List<FoodCategory>> GetFoodCategoriesAsync();
        Task<FoodCategory> GetFoodCategoryByIdAsync(int id);
    }
}
