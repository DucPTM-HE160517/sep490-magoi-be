using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;

namespace FR.DataAccess.DAO
{
    public interface IFoodOrderDAO
    {
        IQueryable<FoodOrder> GetFoodOrdersByOrderId(Guid orderId);
        IQueryable<FoodOrder> GetFoodOrdersByTimeRange(DateTime startDate, DateTime endDate);
        IQueryable<FoodOrder> GetFoodOrdersByStatusId(int statusId);
        Task<FoodOrder> GetFoodOrderByOrderIdAndFoodId(Guid orderId, int foodId);
    }
}
