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
        private readonly FoodDAO _foodDAO;
        public FoodService(FoodDAO foodDAO)
        {
            _foodDAO = foodDAO;
        }

        public List<Food> GetFoods()
        {
            return _foodDAO.GetFoods();
        }
    }
}
