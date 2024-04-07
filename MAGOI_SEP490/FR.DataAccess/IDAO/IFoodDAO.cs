using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.IDAO
{
    public interface IFoodDAO : IBaseDAO<Food>
    {
        List<Food> GetFoodsByCategory(int categoryId);
        void UpdateFoodQuantity(int foodId, int new_quantity);
    }
}
