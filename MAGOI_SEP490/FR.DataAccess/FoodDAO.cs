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
        List<Food> _foodList;
        public FoodDAO(DBContext context)
        {
            _context = context;
            _foodList = context.Foods.ToList();
        }

        public List<Food> GetFoods()
        {
            return _context.Foods.ToList();
        }
    }
}
