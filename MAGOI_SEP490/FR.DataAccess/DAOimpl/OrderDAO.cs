using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;
using FR.Infrastructure.Enums;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess.DAOimpl
{
    public class OrderDAO : BaseDAO<Order>, IOrderDAO
    {
        public OrderDAO(DBContext context) : base(context)
        {
        }

        public async Task<Order> GetOrderByOrderId(Guid id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public IQueryable<Order> GetOrdersByStatusId(int? statusId)
        {
            if (statusId != null)
            {
                return _context.Orders.Where(x => x.OrderStatusId == statusId);
            }
            else
            {
                return _context.Orders;
            }
        }

        public IQueryable<Order> GetOrdersByTableIdAndOrderStatusId(Guid tableId, int orderStatusId)
        {
            return _context.Orders.Where(o => o.TableId == tableId
                                && o.OrderStatusId == orderStatusId);
            
        }

        public IQueryable<Order> GetServingOrdersByTimeRange(DateTime startDate, DateTime endDate)
        {
            return _context.Orders.Where(c => c.OrderStatusId == (int)OrderStatusId.Serving
                                    && c.CreatedAt >= startDate
                                    && c.CreatedAt <= endDate);
        }

        public IQueryable<Order> GetOrdersByBillId(Guid billId)
        {
            return _context.Orders.Where(o => o.BillId == billId);
        }

        public IQueryable<Order> GetOrdersByTableId(Guid tableId)
        {
            return _context.Orders.Where(o => o.TableId == tableId);
        }

        public IQueryable<Order> GetServedOrdersByTimeRange(DateTime startDate, DateTime endDate)
        {
            return _context.Orders.Where(c => c.OrderStatusId == (int)OrderStatusId.Finished
                                    && c.CreatedAt >= startDate
                                    && c.CreatedAt <= endDate);
        }

        public IQueryable<Order> GetServedOrdersByTableId(Guid tableId)
        {
            return _context.Orders.Where(o => o.TableId == tableId
                                    && o.OrderStatusId == (int)OrderStatusId.Finished);
        }

        public IQueryable<Order> GetOrdersByTimeRange(DateTime startDate, DateTime endDate)
        {
            return _context.Orders.Where(c => c.CreatedAt >= startDate && c.CreatedAt <= endDate);
        }

        public async Task<float> GetTotalAmmountOfOrder(Guid orderId)
        {
            float totalAmount = await _context.FoodOrder
                .Where(od => od.OrderId == orderId)
                .SumAsync(od => od.UnitPrice * od.Quantity);

            return totalAmount;
        }

        //public Order GetOrderById(Guid Id)
        //{
        //    return _context.Orders.SingleOrDefault(o => o.Id == Id);
        //}
        //public void AddOrder(Order order)
        //{
        //    try
        //    {
        //        _context.Orders.Add(order);
        //        _context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public void DeleteOrder(Order order)
        //{
        //    try
        //    {
        //        _context.Orders.Remove(order);
        //        _context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public List<Order> GetOrdersByStatusId(int? statusId)
        //{
        //    try
        //    {
        //        if (statusId != null)
        //        {
        //            return _context.Orders.Where(x => x.OrderStatusId == statusId).ToList();
        //        }
        //        else
        //        {
        //            return _context.Orders.ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }
        //}
        //public List<Order> GetOrdersByTableId(Guid tableId)
        //{
        //    try
        //    {
        //        return _context.Orders.Where(o => o.TableId == tableId).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public List<Order> GetOrdersByTableIdAndOrderStatusId(Guid tableId, int orderStatusId)
        //{
        //    try
        //    {
        //        return _context.Orders.Where(o => o.TableId == tableId
        //        && o.OrderStatusId == orderStatusId).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public float GetTotalAmmountOfOrder(Guid orderId)
        //{
        //    try
        //    {
        //        var foodOrders = _context.FoodOrder.Where(od => od.OrderId == orderId).ToList();
        //        float totalAmount = 0;
        //        foreach (var foodOrder in foodOrders)
        //        {
        //            totalAmount += foodOrder.UnitPrice * foodOrder.Quantity;
        //        }
        //        return totalAmount;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public void UpdateOrder(Order order)
        //{
        //    try
        //    {
        //        _context.Entry(order).State = EntityState.Modified;
        //        _context.SaveChanges();
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}
        //public List<Order> GetOrdersByBillId(Guid billId)
        //{
        //    return _context.Orders.Where(o => o.BillId == billId).ToList();
        //}
        //public List<Order> GetServedOrdersByTableId(Guid tableId)
        //{
        //    return _context.Orders.Where(o => o.TableId == tableId
        //                            && o.OrderStatusId == (int)OrderStatusId.Finished).ToList();
        //}
        //public IQueryable<Order> GetServingOrdersByTimeRange(DateTime startDate, DateTime endDate)
        //{
        //    return _context.Orders.Where(c => c.OrderStatusId == (int)OrderStatusId.Serving
        //                            && c.CreatedAt >= startDate
        //                            && c.CreatedAt <= endDate);
        //}
        //public IQueryable<Order> GetServedOrdersByTimeRange(DateTime startDate, DateTime endDate)
        //{
        //    return _context.Orders.Where(c => c.OrderStatusId == (int)OrderStatusId.Finished
        //                            && c.CreatedAt >= startDate
        //                            && c.CreatedAt <= endDate);
        //}
        //public IQueryable<Order> GetOrdersByTimeRange(DateTime startDate, DateTime endDate)
        //{
        //    return _context.Orders.Where(c => c.CreatedAt >= startDate && c.CreatedAt <= endDate);
        //}

    }
}
