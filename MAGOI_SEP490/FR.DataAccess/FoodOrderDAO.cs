using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

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
            _context.FoodOrder.AddRange(foodOrders);
            _context.SaveChanges();
        }
        public void UpdateFoodOrder(FoodOrder foodOrder)
        {
            try
            {
                _context.Entry(foodOrder).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<FoodOrder> GetFoodOrdersByOrderId(Guid orderId)
        {
            return _context.FoodOrder.Where(f => f.OrderId == orderId).ToList();
        }
    }
}
