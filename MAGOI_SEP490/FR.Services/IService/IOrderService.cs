using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types.InputTypes;

namespace FR.Services.IService
{
    public interface IOrderService
    {
        Task<Order> AddOrder(OrderInput order, List<FoodOrderInput> foodListInput);
        Task<Order> GetOrderById(Guid Id);
        Task<List<Order>> GetServedOrdersByTableId(Guid tableId);
        IQueryable<Order> GetOrdersByTableId(Guid tableId);
        Task<List<Order>> GetOrdersByBillId(Guid billId);
        Task<List<Order>> GetOrdersByTableIdAndOrderStatusId(Guid tableId, int orderStatusId);
        Task<Order> UpdateOrderStatus(IExpoNotificationService expoSdkClient,
            Guid orderId, int orderStatusId, bool sendNotification);
        void DeleteOrder(Order order);
        IQueryable<Order> GetOrdersByOrderStatusId(int? orderStatusId);
        Task<List<Order>> GetServingOrdersByTimeRange(DateTime startDate, DateTime endDate);
        Task<List<Order>> GetServedOrdersByTimeRange(DateTime startDate, DateTime endDate);
        IQueryable<Order> GetOrdersByTimeRange(DateTime startDate, DateTime endDate);
        Task<float> GetTotalPriceOfOrders(List<Order> orders);
        void UpdateBillIdOfOrder(Guid orderId, Guid billId);
        Task<Table> FinishOrdersOfTable(Guid tableId, DateTime finishedAt, int paymentMethodId);
    }
}
