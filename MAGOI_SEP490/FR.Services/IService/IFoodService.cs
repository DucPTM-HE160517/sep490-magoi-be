using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface IFoodService
    {
        List<Food> GetFoods();
        List<Food> GetFoodsByCategory(int categoryId);
        Food GetFoodByFoodId(int id);
    }
}
