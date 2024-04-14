using FR.BusinessObjects.Models;
using FR.Common.Ultilities;
using FR.DataAccess.UOW;
using FR.Infrastructure.Enums;
using FR.Services.GraphQL.Types.InputTypes;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.Services.Service
{
    public partial class Service : IOrderService
    {
        public async Task<Order> AddOrder(OrderInput orderInput, List<FoodOrderInput> foodListInput)
        {
            //check order: foods amount exceed food quantity
            if (!(await CheckFoodOrdersQuantity(foodListInput)))
            {
                throw new Exception("food amount exceed");
            }
            //add order
            var order = new Order
            {
                TableId = orderInput.tableId,
                CreatedAt = orderInput.createdAt,
                OrderStatusId = (int)OrderStatusId.Pending,
            };
            await _uow.OrderDAO.AddAsync(order);
            //add food order

            //update quantity of the food
            //update table status
            return order;
        }
        public void DeleteOrderAsync(Order order)
        {
           _dao.Delete(order);
        }
        public async Task<Order> GetOrderById(Guid Id)
        {
            return await _uow.OrderDAO.GetOrderById(Id);
        }
        public IQueryable<Order> GetOrdersByOrderStatusId(int? orderStatusId)
        {
            return _uow.OrderDAO.GetOrdersByStatusId(orderStatusId);
        }
        public async Task<List<Order>> GetOrdersByTableId(Guid tableId)
        {
            return await _dao.GetOrdersByTableId(tableId).ToListAsync();
        }
        public async Task<List<Order>> GetOrdersByTableIdAndOrderStatusId(Guid tableId, int orderStatusId)
        {
            return await _dao.GetOrdersByTableIdAndOrderStatusId(tableId, orderStatusId).ToListAsync();
        }
        public async void UpdateOrderStatus(Guid orderId, int orderStatusId)
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
        public async Task<float> GetTotalPriceOfOrders(List<Order> orders)
        {
            float totalPrice = 0;

            foreach (var order in orders)
            {
                totalPrice += await _dao.GetTotalAmmountOfOrder(order.Id);
            }

            return totalPrice;
        }
        public async void UpdateBillIdOfOrder(Guid orderId, Guid billId)
        {
            Order order = _dao.GetOrderById(orderId);
            order.BillId = billId;
            _dao.Update(order);
        }

        public async Task<List<Order>> GetOrdersByBillId(Guid billId)
        {
            return await _dao.GetOrdersByBillId(billId).ToListAsync();
        }

        public IQueryable<Order> GetServedOrdersByTableIdAndStatus(Guid tableId, int orderStatusId)
        {
            return _uow.OrderDAO.GetOrdersByTableIdAndStatus(tableId, orderStatusId);
        }

        public IQueryable<Order> GetOrdersByTimeRangeAndStatus(DateTime startDate, DateTime endDate, int orderStatusId)
        {
            startDate = Ultilities.AbsoluteStart(startDate);
            endDate = Ultilities.AbsoluteEnd(endDate);

            return _uow.OrderDAO.GetOrdersByTimeRangeAndStatus(startDate, endDate, orderStatusId);
        }
        public IQueryable<Order> GetOrdersByTimeRange(DateTime startDate, DateTime endDate)
        {
            startDate = Ultilities.AbsoluteStart(startDate);
            endDate = Ultilities.AbsoluteEnd(endDate);
            return _uow.OrderDAO.GetOrdersByTimeRange(startDate, endDate);
        }
    }
}
