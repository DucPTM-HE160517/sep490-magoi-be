using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.DAO
{
    public interface IOrderDAO : IBaseDAO<Order>
    {
        Task<Order> GetOrderByOrderId(Guid id);
        IQueryable<Order> GetOrdersByStatusId(int? statusId);
        IQueryable<Order> GetOrdersByTableId(Guid tableId);
        IQueryable<Order> GetOrdersByBillId(Guid billId);
        IQueryable<Order> GetOrdersByTableIdAndOrderStatusId(Guid tableId, int orderStatusId);
        IQueryable<Order> GetServingOrdersByTimeRange(DateTime startDate, DateTime endDate);
        IQueryable<Order> GetServedOrdersByTimeRange(DateTime startDate, DateTime endDate);
        IQueryable<Order> GetServedOrdersByTableId(Guid tableId);
        IQueryable<Order> GetOrdersByTimeRange(DateTime startDate, DateTime endDate);
        Task<float> GetTotalAmmountOfOrder(Guid orderId);
        Order GetOrderById(Guid orderId);
    }
}
