using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess.DAOimpl
{
    public class FoodDAO : BaseDAO<Food>, IFoodDAO
    {

        public FoodDAO(DBContext context) : base(context)
        {
        }

        public async Task<Food> GetFoodByFoodId(int id)
        {
            return await _context.Foods.FindAsync(id);
        }

        public IQueryable<Food> GetFoodsByCategory(int categoryId)
        {
            return _context.Foods.Where(x => x.FoodCategoryId == categoryId);
        }
    }
}
