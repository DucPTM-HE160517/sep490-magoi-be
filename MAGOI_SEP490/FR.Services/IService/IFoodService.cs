using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;
using FR.DataAccess;

namespace FR.Services.IService
{
    public interface IFoodService
    {
        List<Food> GetFoods();
        Food GetFood(int id);
        List<FoodCategory> GetFoods1();
    }
}
