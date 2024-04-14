using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.DAO
{
    public interface IFoodCategoryDAO : IBaseDAO<FoodCategory>
    {
        Task<FoodCategory> GetById(int id);
        Task<IEnumerable<FoodCategory>> GetCategoryOfCookingFoods();
    }
}
