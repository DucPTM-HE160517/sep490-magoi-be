using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.Services.IService;
using FR.BusinessObjects.Models;
using FR.BusinessObjects.DataContext;
using FR.DataAccess;

namespace FR.Services.Service
{
    public class FoodService : IFoodService
    {
        private readonly FoodDAO _dao;
        public FoodService(FoodDAO dao)
        {
            _dao = dao;
        }

        public Food GetFood(int id)
        {
            return _dao.GetFood(id);
        }

        public List<Food> GetFoods()
        {
            return _dao.GetFoods();
        }

        public List<FoodCategory> GetFoods1()
        {
            return _dao.GetFoods1();
        }
    }
}
