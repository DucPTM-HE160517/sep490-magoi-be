using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess
{
    public class FoodOrderDAO
    {
        private readonly DBContext _context;
        public FoodOrderDAO(DBContext context)
        {
            _context = context;
        }
        public void AddFoodOrders(List<FoodOrder> foodOrders)
        {
            _context.FoodOrder.AddRange(foodOrders);
            _context.SaveChanges();
        }
        public void UpdateFoodOrder(FoodOrder foodOrder)
        {
            try
            {
                _context.Entry(foodOrder).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<FoodOrder> GetFoodOrdersByOrderId(Guid orderId)
        {
            return _context.FoodOrder.Where(f => f.OrderId == orderId).ToList();
        }
        public FoodOrder GetFoodOrderByOrderIdAndFoodId(Guid orderId, int foodId)
        {
            return _context.FoodOrder.SingleOrDefault(f => f.OrderId == orderId && f.FoodId == foodId);
        }
        public float GetFoodPrice(int foodId) => _context.Foods.SingleOrDefault(f => f.Id == foodId).UnitPrice;
        public Food GetFood(int foodId) => _context.Foods.SingleOrDefault(f => f.Id == foodId);
        public List<FoodOrder> GetFoodOrdersByTimeRange(DateTime startDate, DateTime endDate)
        {
            return _context.FoodOrder.Where(c => c.OrderAt >= startDate && c.OrderAt <= endDate).ToList();
        }
    }
}
