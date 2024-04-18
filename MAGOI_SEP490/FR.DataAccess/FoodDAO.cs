using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.Infrastructure.Enums;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess
{
    public class FoodDAO
    {
        private readonly DBContext _context;
        public FoodDAO(DBContext context)
        {
            _context = context;
        }

        public List<Food> GetFoods(bool foodStatus)
        {
            return _context.Foods.Where(f => f.IsActive == foodStatus).ToList();
        }
        public List<Food> GetFoodsByCategory(int categoryId)
        {
            return _context.Foods.Where(x => x.FoodCategoryId == categoryId).ToList();
        }
        public Food GetFoodByFoodId(int foodId)
        {
            return _context.Foods.FirstOrDefault(x => x.Id == foodId);
        }
        public void UpdateFoodQuantity(int foodId, int new_quantity)
        {
            var food = _context.Foods.FirstOrDefault(x => x.Id == foodId);
            food.Quantity = new_quantity;
            _context.SaveChanges();
        }
        public void AddFood(Food food)
        {
            _context.Foods.Add(food);
            _context.SaveChanges();
        }
        public void UpdateFood(Food food)
        {
            _context.Entry(food).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public bool CheckFoodExistFoodOrder(int id)
        {
            List<Order> orders = new();
            var foodOrders = _context.FoodOrder.ToList();
            foreach (var food in foodOrders)
            {
                if(food.FoodId == id)
                {
                    orders.Add(_context.Orders.Find(food.OrderId));
                }
            }

            return orders.Any(o => o.OrderStatusId != (int)OrderStatusId.Finished);
            
        }
    }
}
