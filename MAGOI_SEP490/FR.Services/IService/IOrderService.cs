using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types.InputTypes;

namespace FR.Services.IService
{
    public interface IOrderService
    {
        Task<Order> AddOrderAsync(OrderInput order);
        Task<Order> GetOrderByIdAsync(Guid Id);
        Task<List<Order>> GetServedOrdersByTableIdAsync(Guid tableId);
        Task<List<Order>> GetOrdersByTableIdAsync(Guid tableId);
        Task<List<Order>> GetOrdersByBillIdAsync(Guid billId);
        Task<List<Order>> GetOrdersByTableIdAndOrderStatusIdAsync(Guid tableId, int orderStatusId);
        void UpdateOrderStatusAsync(Guid orderId, int orderStatusId);
        void DeleteOrderAsync(Order order);
        Task<List<Order>> GetOrdersByOrderStatusIdAsync(int? orderStatusId);
        Task<List<Order>> GetServingOrdersByTimeRangeAsync(DateTime startDate, DateTime endDate);
        Task<List<Order>> GetServedOrdersByTimeRangeAsync(DateTime startDate, DateTime endDate);
        Task<List<Order>> GetOrdersByTimeRangeAsync(DateTime startDate, DateTime endDate);
        Task<float> GetTotalPriceOfOrdersAsync(List<Order> orders);
        void UpdateBillIdOfOrderAsync(Guid orderId, Guid billId);
    }
}
