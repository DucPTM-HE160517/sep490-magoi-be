﻿using FR.BusinessObjects.Models;

namespace FR.DataAccess.DAO
{
    public interface IFoodDAO
    {
        IQueryable<Food> GetFoodsByCategory(int categoryId);
        Task<Food> GetFoodByFoodId(int id);
    }
}
