using FR.BusinessObjects.Models;

namespace FR.DataAccess.DAO
{
    public interface IOrderDAO
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
        public float GetTotalAmmountOfOrder(Guid orderId);
        

    }
}
