using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.DataAccess
{
    public class OrderDAO
    {
        private readonly DBContext _context;
        public OrderDAO(DBContext context)
        {
            _context = context;
        }

        public Order GetOrderById(Guid Id)
        {
            return _context.Orders.SingleOrDefault(o => o.Id == Id);
        }
        public void AddOrder(Order order)
        {
            try
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteOrder(Order order)
        {
            try
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Order> GetOrdersByStatusId(int? statusId)
        {
            try
            {
                if (statusId != null)
                {
                    return _context.Orders.Where(x => x.OrderStatusId == statusId).ToList();
                }
                else
                {
                    return _context.Orders.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Order> GetOrdersByTableId(Guid tableId)
        {
            try
            {
                return _context.Orders.Where(o => o.TableId == tableId).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
