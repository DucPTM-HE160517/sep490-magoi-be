using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types.InputTypes;

namespace FR.Services.IService
{
    public interface IOrderService
    {
        Task<Order> AddOrder(OrderInput order, List<FoodOrderInput> foodListInput);
        Task<Order> GetOrderById(Guid Id);
        Task<List<Order>> GetServedOrdersByTableId(Guid tableId);
        Task<List<Order>> GetOrdersByTableId(Guid tableId);
        Task<List<Order>> GetOrdersByBillId(Guid billId);
        Task<List<Order>> GetOrdersByTableIdAndOrderStatusId(Guid tableId, int orderStatusId);
        void UpdateOrderStatus(Guid orderId, int orderStatusId);
        void DeleteOrder(Order order);
        IQueryable<Order> GetOrdersByOrderStatusId(int? orderStatusId);
        Task<List<Order>> GetServingOrdersByTimeRange(DateTime startDate, DateTime endDate);
        Task<List<Order>> GetServedOrdersByTimeRange(DateTime startDate, DateTime endDate);
        IQueryable<Order> GetOrdersByTimeRange(DateTime startDate, DateTime endDate);
        Task<float> GetTotalPriceOfOrders(List<Order> orders);
        void UpdateBillIdOfOrder(Guid orderId, Guid billId);
    }
}
