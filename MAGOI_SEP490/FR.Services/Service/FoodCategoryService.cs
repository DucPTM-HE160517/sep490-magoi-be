using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class FoodCategoryService : IFoodCategoryService
    {
        private readonly FoodCategoryDAO _dao;
        public FoodCategoryService(FoodCategoryDAO dao)
        {
            _dao = dao;
        }

        public List<FoodCategory> GetCategoryOfCookingFoods()
        {
            return _dao.GetCategoryOfCookingFoods();
        }

        public List<FoodCategory> GetFoodCategories()
        {
            return _dao.GetCategoryOfCookingFoods();
        }

        public FoodCategory GetFoodCategoryById(int id)
        {
            return _dao.GetFoodCategoryById(id);
        }
    }
}
