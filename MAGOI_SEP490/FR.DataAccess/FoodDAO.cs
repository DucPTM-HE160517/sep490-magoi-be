using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FR.DataAccess
{
    public class FoodDAO
    {
        private readonly DBContext _context;
        public FoodDAO(DBContext context)
        {
            _context = context;
        }

        public List<Food> GetFoods()
        {
            return _context.Foods.ToList();
        }
        public Food GetFood(int id)
        {
            return _context.Foods.FirstOrDefault(f=> f.Id == id);
        }

        public List<FoodCategory> GetFoods1()
        {
            return _context.FoodCategories.ToList();
        }
    }
}
