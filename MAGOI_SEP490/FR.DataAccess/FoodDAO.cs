using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using HotChocolate;

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
    }
}
