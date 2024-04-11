using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;

namespace FR.DataAccess.DAOimpl
{
    public class FoodCategoryDAO : BaseDAO<FoodCategory>, IFoodCategoryDAO
    {
        public FoodCategoryDAO(DBContext context) : base(context)
        {
        }

        public async Task<FoodCategory> GetById(int id)
        {
            return await _context.FoodCategories.FindAsync(id);
        }

        public Task<List<FoodCategory>> GetCategoryOfCookingFoods()
        {
            List<FoodCategory> foodCategories = new();
            //    HashSet<int> categoriesId = new();

            //    foreach (var fo in _context.FoodOrder.ToList())
            //    {
            //        Food f = _context.Foods.SingleOrDefault(f => f.Id == fo.FoodId);
            //        if (!categoriesId.Contains(f.FoodCategoryId))
            //        {
            //            categoriesId.Add(f.FoodCategoryId);
            //        }
            //    }

            //    foreach (var id in categoriesId)
            //    {
            //        foodCategories.Add(_context.FoodCategories.SingleOrDefault(c => c.Id == id));
            //    }

            //    return foodCategories;
        }

        //public List<FoodCategory> GetCategoryOfCookingFoods()
        //{
        //    List<FoodCategory> foodCategories = new();
        //    HashSet<int> categoriesId = new();

        //    foreach (var fo in _context.FoodOrder.ToList())
        //    {
        //        Food f = _context.Foods.SingleOrDefault(f => f.Id == fo.FoodId);
        //        if (!categoriesId.Contains(f.FoodCategoryId))
        //        {
        //            categoriesId.Add(f.FoodCategoryId);
        //        }
        //    }

        //    foreach (var id in categoriesId)
        //    {
        //        foodCategories.Add(_context.FoodCategories.SingleOrDefault(c => c.Id == id));
        //    }

        //    return foodCategories;
        //}
        //public FoodCategory GetFoodCategoryById(int id)
        //{
        //    return _context.FoodCategories.SingleOrDefault(fc => fc.Id == id);
        //}
    }
}
