using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
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

        public IQueryable<Food> GetFoods()
        {
            return _context.Foods;
        }
        public IQueryable<Food> GetFoodsByCategory(int categoryId)
        {
            return _context.Foods.Where(x => x.FoodCategoryId == categoryId);
        }
        public async Task<Food> GetFoodByFoodId(int foodId)
        {
            return await _context.Foods.FirstOrDefaultAsync(x => x.Id == foodId);
        }
        public async Task UpdateFoodQuantity(int foodId, int new_quantity)
        {
            var food = await _context.Foods.FirstOrDefaultAsync(x => x.Id == foodId);
            food.Quantity = new_quantity;
            await _context.SaveChangesAsync();
        }
        public async Task<Food> AddFood(Food food)
        {
            await _context.Foods.AddAsync(food);
            await _context.SaveChangesAsync();

            return food;
        }
        public void UpdateFood(Food food)
        {
            _context.Entry(food).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
