using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.DAO
{
    public interface IFoodDAO : IBaseDAO<Food>
    {
        IQueryable<Food> GetFoodsByCategory(int categoryId);
        Task<Food> GetFoodByFoodId(int id);
    }
}
