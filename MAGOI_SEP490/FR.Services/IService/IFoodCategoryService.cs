using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface IFoodCategoryService
    {
        List<FoodCategory> GetCategoryOfCookingFoods();
        IQueryable<FoodCategory> GetFoodCategories();
        FoodCategory GetFoodCategoryById(int id);
    }
}
