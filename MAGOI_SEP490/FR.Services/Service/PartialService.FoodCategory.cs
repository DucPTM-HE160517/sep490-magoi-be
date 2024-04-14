using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.Services.Service
{
    public partial class Service : IFoodCategoryService
    {
        public async Task<IEnumerable<FoodCategory>> GetCategoryOfCookingFoods()
        {
            return await _uow.FoodCategoryDAO.GetCategoryOfCookingFoods();
        }

        public async Task<IEnumerable<FoodCategory>> GetFoodCategories() 
        {
            return await _uow.FoodCategoryDAO.GetAllAsync();
        }

        public async Task<FoodCategory> GetFoodCategoryById(int id)
        {
            return await _uow.FoodCategoryDAO.GetById(id);
        }
    }
}
