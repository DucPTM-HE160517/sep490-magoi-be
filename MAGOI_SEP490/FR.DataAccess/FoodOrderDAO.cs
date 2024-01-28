using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.DataAccess
{
    public class FoodOrderDAO
    {
        private readonly DBContext _context;
        public FoodOrderDAO(DBContext context)
        {
            _context = context;
        }
        public void AddFoodOrders(List<FoodOrder> foodOrders)
        {
            try
            {
                //for(int i = 0; i < foodOrders.Count; i++)
                //{
                //    _context.FoodOrder.Add(foodOrders[i]);
                //    _context.SaveChanges();
                //}
                _context.FoodOrder.AddRange(foodOrders);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<FoodOrder> GetFoodOrdersByOrderId(int orderId)
        {
            return _context.FoodOrder.Where(f => f.OrderId == orderId).ToList();
        }
    }
}
