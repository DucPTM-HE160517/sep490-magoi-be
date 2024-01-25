using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.DataAccess
{
    public class FoodCategoryDAO
    {
        private readonly DBContext _context;
        public FoodCategoryDAO(DBContext context)
        {
            _context = context;
        }

        public FoodCategory GetFoodCategoryById(int id)
        {
            return _context.FoodCategories.SingleOrDefault(fc => fc.Id == id);
        }
    }
}
