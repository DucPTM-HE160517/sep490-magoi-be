using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.DAO
{
    public interface IOrderDAO : IBaseDAO<Order>
    {
        IQueryable<Order> GetOrdersByStatusId(int? statusId);
        IQueryable<Order> GetOrdersByTableId(Guid tableId);
        IQueryable<Order> GetOrdersByBillId(Guid billId);
        IQueryable<Order> GetOrdersByTimeRangeAndStatus(DateTime startDate, DateTime endDate, int orderStatusId);
        IQueryable<Order> GetOrdersByTableIdAndStatus(Guid tableId, int orderStatusId);
        IQueryable<Order> GetOrdersByTimeRange(DateTime startDate, DateTime endDate);
        Task<float> GetTotalAmmountOfOrder(Guid orderId);
        Task<Order> GetOrderById(Guid orderId);
    }
}
