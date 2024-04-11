﻿using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess.DAOimpl
{
    public class FoodDAO : BaseDAO<Food>, IFoodCategoryDAO
    {

        //public List<Food> GetFoods()
        //{
        //    return _context.Foods.ToList();
        //}
        //public List<Food> GetFoodsByCategory(int categoryId)
        //{
        //    return _context.Foods.Where(x => x.FoodCategoryId == categoryId).ToList();
        //}
        //public Food GetFoodByFoodId(int foodId)
        //{
        //    return _context.Foods.FirstOrDefault(x => x.Id == foodId);
        //}
        //public void UpdateFoodQuantity(int foodId, int new_quantity)
        //{
        //    var food = _context.Foods.FirstOrDefault(x => x.Id == foodId);
        //    food.Quantity = new_quantity;
        //    _context.SaveChanges();
        //}
        //public void AddFood(Food food)
        //{
        //    _context.Foods.Add(food);
        //    _context.SaveChanges();
        //}
        //public void UpdateFood(Food food)
        //{
        //    _context.Entry(food).State = EntityState.Modified;
        //    _context.SaveChanges();
        //}
        public FoodDAO(DBContext context) : base(context)
        {
        }

        public Task<Food> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Food> GetFoodsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
