using FR.Services.IService;
using FR.BusinessObjects.Models;
using FR.DataAccess;

namespace FR.Services.Service
{
    public class FoodService : IFoodService
    {
        private readonly FoodDAO _foodDAO;
        public FoodService(FoodDAO foodDAO)
        {
            _foodDAO = foodDAO;
        }

        public List<Food> GetFoods()
        {
            return _foodDAO.GetFoods();
        }

        public List<Food> GetFoodsByCategory(int categoryId)
        {
            return _foodDAO.GetFoodsByCategory(categoryId);
        }
    }
}
