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
        List<Order> GetServingOrdersByTimeRange(DateTime date);
        List<Order> GetServedOrdersByTimeRange(DateTime date);
        List<Order> GetOrdersByTimeRange(DateTime date);
        public float GetTotalPriceOfOrders(List<Order> orders);
        public void UpdateBillIdOfOrder(Guid orderId, Guid billId);
    }
}
