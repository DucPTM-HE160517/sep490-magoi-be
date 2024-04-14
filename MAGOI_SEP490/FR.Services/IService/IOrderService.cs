using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types.InputTypes;

namespace FR.Services.IService
{
    public interface IOrderService
    {
        Task<Order> AddOrder(OrderInput order, List<FoodOrderInput> foodListInput);
        Task<Order> GetOrderById(Guid Id);
        IQueryable<Order> GetOrdersByTableId(Guid tableId);
        Task<List<Order>> GetOrdersByBillId(Guid billId);
        IQueryable<Order> GetOrdersByTableIdAndOrderStatusId(Guid tableId, int orderStatusId);
        Task<Order> UpdateOrderStatus(IExpoNotificationService expoSdkClient,
            Guid orderId, int orderStatusId, bool sendNotification);
        IQueryable<Order> GetOrdersByOrderStatusId(int? orderStatusId);
        IQueryable<Order> GetOrdersByTimeRange(DateTime startDate, DateTime endDate);
        Task<float> GetTotalPriceOfOrders(List<Order> orders);
        Task<Table> FinishOrdersOfTable(Guid tableId, DateTime finishedAt, int paymentMethodId);
    }
}
