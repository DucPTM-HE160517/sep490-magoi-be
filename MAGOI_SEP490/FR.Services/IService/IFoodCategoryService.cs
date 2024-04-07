using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface IFoodCategoryService
    {
        IQueryable<FoodCategory> GetFoodCategories();
        FoodCategory GetFoodCategoryById(int id);
    }
}
