using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess.DAOimpl
{
    public class FoodOrderDAO : BaseDAO<FoodOrder>, IFoodOrderDAO
    {
        public FoodOrderDAO(DBContext context) : base(context)
        {
        }

        public async Task<FoodOrder> GetFoodOrderByOrderIdAndFoodId(Guid orderId, int foodId)
        {
            return await _context.FoodOrder.SingleOrDefaultAsync(f => f.OrderId == orderId && f.FoodId == foodId);
        }

        public IQueryable<FoodOrder> GetFoodOrdersByOrderId(Guid orderId)
        {
            return _context.FoodOrder.Where(f => f.OrderId == orderId);
        }

        public IQueryable<FoodOrder> GetFoodOrdersByTimeRange(DateTime startDate, DateTime endDate)
        {
            return _context.FoodOrder.Where(c => c.OrderAt >= startDate && c.OrderAt <= endDate);
        }

        public IQueryable<FoodOrder> GetFoodOrdersByStatusId(int statusId)
        {
            return _context.FoodOrder.Where(f => f.FoodOrderStatusId == statusId);
        }
        public float GetFoodUnitPriceByFoodId(int foodId)
        {
            return _context.Foods.FirstOrDefault(f => f.Id == foodId).UnitPrice;
        }
    }
}
