using FR.BusinessObjects.Models;
using FR.Common.Ultilities;
using FR.DataAccess.DAO;
using FR.DataAccess.DAOimpl;
using FR.DataAccess.UOW;
using FR.Infrastructure.Enums;
using FR.Services.GraphQL.Types.InputTypes;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;
using static HotChocolate.ErrorCodes;

namespace FR.Services.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderDAO _dao;
        private readonly IUnitOfWork _uow;
        public OrderService(IUnitOfWork uow)
        {
            _uow = uow;
            _dao = ((UnitOfWork)uow).Order;
        }

        public async Task<Order> AddOrderAsync(OrderInput orderInput)
        {
            var order = new Order
            {
                TableId = orderInput.tableId,
                CreatedAt = orderInput.createdAt,
                OrderStatusId = (int)OrderStatusId.Pending,
            };
            await _dao.AddAsync(order);
            return order;
        }
        public void DeleteOrderAsync(Order order)
        {
           _dao.Delete(order);
        }
        public async Task<Order> GetOrderByIdAsync(Guid Id)
        {
            return await _dao.GetOrderByOrderId(Id);
        }
        public async Task<List<Order>> GetOrdersByOrderStatusIdAsync(int? orderStatusId)
        {
            return await _dao.GetOrdersByStatusId(orderStatusId).ToListAsync();
        }
        public async Task<List<Order>> GetOrdersByTableIdAsync(Guid tableId)
        {
            return await _dao.GetOrdersByTableId(tableId).ToListAsync();
        }
        public async Task<List<Order>> GetOrdersByTableIdAndOrderStatusIdAsync(Guid tableId, int orderStatusId)
        {
            return await _dao.GetOrdersByTableIdAndOrderStatusId(tableId, orderStatusId).ToListAsync();
        }
        public async void UpdateOrderStatusAsync(Guid orderId, int orderStatusId)
        {
            try
            {
                Order o = _dao.GetOrderById(orderId);
                o.OrderStatusId = orderStatusId;
                _dao.Update(o);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<float> GetTotalPriceOfOrdersAsync(List<Order> orders)
        {
            float totalPrice = 0;

            foreach (var order in orders)
            {
                totalPrice += await _dao.GetTotalAmmountOfOrder(order.Id);
            }

            return totalPrice;
        }
        public async void UpdateBillIdOfOrderAsync(Guid orderId, Guid billId)
        {
            Order order = _dao.GetOrderById(orderId);
            order.BillId = billId;
            _dao.Update(order);
        }

        public async Task<List<Order>> GetOrdersByBillIdAsync(Guid billId)
        {
            return await _dao.GetOrdersByBillId(billId).ToListAsync();
        }

        public async Task<List<Order>> GetServedOrdersByTableIdAsync(Guid tableId)
        {
            return await _dao.GetServedOrdersByTableId(tableId).ToListAsync();
        }

        public async Task<List<Order>> GetServingOrdersByTimeRangeAsync(DateTime startDate, DateTime endDate)
        {
            startDate = Ultilities.AbsoluteStart(startDate);
            endDate = Ultilities.AbsoluteEnd(endDate);

            return await _dao.GetServingOrdersByTimeRange(startDate, endDate).ToListAsync();
        }

        public async Task<List<Order>> GetServedOrdersByTimeRangeAsync(DateTime startDate, DateTime endDate)
        {
            startDate = Ultilities.AbsoluteStart(startDate);
            endDate = Ultilities.AbsoluteEnd(endDate);

            return await _dao.GetServedOrdersByTimeRange(startDate, endDate).ToListAsync();
        }
        public async Task<List<Order>> GetOrdersByTimeRangeAsync(DateTime startDate, DateTime endDate)
        {
            startDate = Ultilities.AbsoluteStart(startDate);
            endDate = Ultilities.AbsoluteEnd(endDate);
            return await _dao.GetOrdersByTimeRange(startDate, endDate).ToListAsync();
        }
    }
}
