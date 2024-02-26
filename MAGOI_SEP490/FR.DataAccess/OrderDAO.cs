using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

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
            catch (Exception ex)
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
        public List<Order> GetOrdersByTableIdAndOrderStatusId(Guid tableId, int orderStatusId)
        {
            try
            {
                return _context.Orders.Where(o => o.TableId == tableId
                && o.OrderStatusId == orderStatusId).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateFinishedOrderStatus(Guid orderId)
        {
            try
            {
                var order = _context.Orders.SingleOrDefault(o => o.Id == orderId);
                order.OrderStatusId = (int)OrderStatusId.Finished;
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public float GetTotalAmmountOfOrder(Guid orderId)
        {
            try
            {
                var foodOrders = _context.FoodOrder.Where(od => od.OrderId == orderId).ToList();
                float totalAmount = 0;
                foreach (var foodOrder in foodOrders)
                {
                    totalAmount += foodOrder.UnitPrice * foodOrder.Quantity;
                }
                return totalAmount;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateOrder(Order order)
        {
            try
            {
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
