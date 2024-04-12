using FR.BusinessObjects.Models;
using FR.DataAccess.DAO;
using FR.DataAccess.DAOimpl;
using FR.DataAccess.UOW;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class FoodCategoryService : IFoodCategoryService
    {
        private readonly IFoodCategoryDAO _dao;
        private readonly IUnitOfWork _uow;
        public FoodCategoryService(IUnitOfWork uow)
        {
            _uow = uow;
            _dao = ((UnitOfWork)uow).FoodCategory;
        }

        public async Task<List<FoodCategory>> GetCategoryOfCookingFoodsAsync()
        {
            return (List<FoodCategory>)await _dao.GetCategoryOfCookingFoods();
        }

        public async Task<List<FoodCategory>> GetFoodCategoriesAsync() 
        {
            return (List<FoodCategory>)await _dao.GetAllAsync();
        }

        public async Task<FoodCategory> GetFoodCategoryByIdAsync(int id)
        {
            return await _dao.GetById(id);
        }
    }
}
