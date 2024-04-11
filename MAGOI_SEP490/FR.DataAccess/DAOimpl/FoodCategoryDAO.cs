using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;
using FR.Infrastructure.Enums;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<FoodCategory>> GetCategoryOfCookingFoods()
        {
            List<FoodCategory> foodCategories = new();
            HashSet<int> categoriesId = new();
            var cookingFoods = _context.FoodOrder.Where(f => f.FoodOrderStatusId == (int)FoodOrderStatusId.Cooking);
            foreach (var fo in cookingFoods)
            {
                Food f = await _context.Foods.SingleOrDefaultAsync(f => f.Id == fo.FoodId);
                if (f != null && !categoriesId.Contains(f.FoodCategoryId))
                {
                    categoriesId.Add(f.FoodCategoryId);
                }
            }

            foreach (var id in categoriesId)
            {
                FoodCategory category = await _context.FoodCategories.SingleOrDefaultAsync(c => c.Id == id);
                if (category != null)
                {
                    foodCategories.Add(category);
                }
            }

            return foodCategories;
        }

        //public Task<List<FoodCategory>> GetCategoryOfCookingFoods()
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
