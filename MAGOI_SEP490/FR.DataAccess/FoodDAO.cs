using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.IDAO;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess
{
    public class FoodDAO : BaseDAO<Food>, IFoodDAO
    {
        public FoodDAO(DBContext context) : base(context)
        {
        }
        public List<Food> GetFoodsByCategory(int categoryId)
        {
            return _context.Foods.Where(x => x.FoodCategoryId == categoryId).ToList();
        }
        public void UpdateFoodQuantity(int foodId, int new_quantity)
        {
            var food = _context.Foods.FirstOrDefault(x => x.Id == foodId);
            food.Quantity = new_quantity;
            _context.SaveChanges();
        }
    }
}
