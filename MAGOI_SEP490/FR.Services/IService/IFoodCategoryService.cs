using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;

namespace FR.Services.IService
{
    public interface IFoodCategoryService
    {
        List<FoodCategory> GetFoodCategories();
        FoodCategory GetFoodCategoryById(int id);
        List<FoodOrderCategory>  GetFoodOrderCategories();
    }
}
