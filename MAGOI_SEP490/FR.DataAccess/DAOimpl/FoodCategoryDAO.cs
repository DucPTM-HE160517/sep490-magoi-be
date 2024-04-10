using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.DataAccess.DAOimpl
{
    public class FoodCategoryDAO
    {
        private readonly DBContext _context;
        public FoodCategoryDAO(DBContext context)
        {
            _context = context;
        }

        public List<FoodCategory> GetCategoryOfCookingFoods()
        {
            List<FoodCategory> foodCategories = new();
            HashSet<int> categoriesId = new();

            foreach (var fo in _context.FoodOrder.ToList())
            {
                Food f = _context.Foods.SingleOrDefault(f => f.Id == fo.FoodId);
                if (!categoriesId.Contains(f.FoodCategoryId))
                {
                    categoriesId.Add(f.FoodCategoryId);
                }
            }

            foreach (var id in categoriesId)
            {
                foodCategories.Add(_context.FoodCategories.SingleOrDefault(c => c.Id == id));
            }

            return foodCategories;
        }
        public FoodCategory GetFoodCategoryById(int id)
        {
            return _context.FoodCategories.SingleOrDefault(fc => fc.Id == id);
        }
    }
}
