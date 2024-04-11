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
    }
}
