using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class FoodCategoryService : IFoodCategoryService
    {
        private readonly FoodCategoryDAO _dao;
        public FoodCategoryService(FoodCategoryDAO dao)
        {
            _dao = dao;
        }

        public FoodCategory GetFoodCategoryById(int id)
        {
            return _dao.GetFoodCategoryById(id);
        }
    }
}
