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
        IQueryable<FoodOrder> GetFoodOrders(Guid orderId);
        IQueryable<FoodOrder> GetFoodOrders(DateTime startDate, DateTime endDate);
        IQueryable<FoodOrder> GetFoodOrders(int statusId);
        Task<FoodOrder> GetFoodOrder(Guid orderId, int foodId);
    }
}
