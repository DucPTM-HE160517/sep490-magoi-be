using FR.BusinessObjects.Models;
using FR.Services.GraphQL.InputTypes;

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
        void UpdateFinishedOrderStatus(Guid orderId);
        void DeleteOrder(Order order);
        List<Order> GetOrdersByOrderStatusId(int? orderStatusId);
        public float GetTotalPriceOfOrders(List<Order> orders);
        public void UpdateBillIdOfOrder(Guid orderId, Guid billId);
    }
}
