using FR.BusinessObjects.Models;

namespace FR.DataAccess.DAO
{
    public interface IOrderDAO
    {
        Task<Order> GetById(Guid id);
        IQueryable<Order> GetOrders(int? statusId);
        IQueryable<Order> GetOrdersByTableId(Guid tableId);
        IQueryable<Order> GetOrdersByBillId(Guid billId);
        IQueryable<Order> GetOrders(Guid tableId, int orderStatusId);
        IQueryable<Order> GetOrders(DateTime startDate, DateTime endDate);
        IQueryable<Order> GetServedOrders(DateTime startDate, DateTime endDate);
        IQueryable<Order> GetServedOrders(Guid tableId);
        IQueryable<Order> GetServingOrders(DateTime startDate, DateTime endDate);
        IQueryable<float> GetTotalAmmountOfOrder(Guid orderId);
        

    }
}
