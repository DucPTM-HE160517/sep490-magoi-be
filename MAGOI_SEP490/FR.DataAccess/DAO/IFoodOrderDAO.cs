using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.DAO
{
    public interface IFoodOrderDAO : IBaseDAO<FoodOrder>
    {
        IQueryable<FoodOrder> GetFoodOrdersByOrderId(Guid orderId);
        IQueryable<FoodOrder> GetFoodOrdersByTimeRange(DateTime startDate, DateTime endDate);
        IQueryable<FoodOrder> GetFoodOrdersByStatusId(int statusId);
        Task<FoodOrder> GetFoodOrderByOrderIdAndFoodId(Guid orderId, int foodId);
        Task AddRangeAsync(IEnumerable<FoodOrder> listFoodOrder);
    }
}
