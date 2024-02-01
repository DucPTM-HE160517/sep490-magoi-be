using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using HotChocolate;
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

        public List<Food> GetFoods()
        {
            return _context.Foods.ToList();
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
            _context.Foods.Where(f => f.Id == foodId).ExecuteUpdate(s => s.SetProperty(f => f.Quantity, new_quantity));
        }
    }
}
