using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types.InputTypes;

namespace FR.Services.IService
{
    public interface IOrderService
    {
        Order AddOrder(OrderInput order);
        Order GetOrderById(Guid Id);
        List<Order> GetServedOrdersByTableId(Guid tableId);
        List<Order> GetOrdersByTableId(Guid tableId);
        List<Order> GetOrdersByBillId(Guid billId);
        List<Order> GetOrdersByTableIdAndOrderStatusId(Guid tableId, int orderStatusId);
        void UpdateOrderStatus(Guid orderId, int orderStatusId);
        void DeleteOrder(Order order);
        List<Order> GetOrdersByOrderStatusId(int? orderStatusId);
        IQueryable<Order> GetServingOrdersByTimeRange(DateTime startDate, DateTime endDate);
        IQueryable<Order> GetServedOrdersByTimeRange(DateTime startDate, DateTime endDate);
        IQueryable<Order> GetOrdersByTimeRange(DateTime startDate, DateTime endDate);
        public float GetTotalPriceOfOrders(List<Order> orders);
        public void UpdateBillIdOfOrder(Guid orderId, Guid billId);
    }
}
