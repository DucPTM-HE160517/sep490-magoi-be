using FR.BusinessObjects.Models;
using FR.Common.Ultilities;
using FR.DataAccess;
using FR.Infrastructure.Enums;
using FR.Services.GraphQL.Types.InputTypes;
using FR.Services.IService;
using static HotChocolate.ErrorCodes;

namespace FR.Services.Service
{
    public class OrderService : IOrderService
    {
        private readonly OrderDAO _dao;
        public OrderService(OrderDAO dao)
        {
            _dao = dao;
        }

        public Order AddOrder(OrderInput orderInput)
        {
            var order = new Order
            {
                TableId = orderInput.tableId,
                CreatedAt = orderInput.createdAt,
                OrderStatusId = (int)OrderStatusId.Pending,
            };
            _dao.AddOrder(order);
            return order;
        }
        public void DeleteOrder(Order order)
        {
            _dao.DeleteOrder(order);
        }
        public Order GetOrderById(Guid Id)
        {
            return _dao.GetOrderById(Id);
        }
        public List<Order> GetOrdersByOrderStatusId(int? orderStatusId)
        {
            return _dao.GetOrdersByStatusId(orderStatusId);
        }
        public List<Order> GetOrdersByTableId(Guid tableId)
        {
            return _dao.GetOrdersByTableId(tableId);
        }
        public List<Order> GetOrdersByTableIdAndOrderStatusId(Guid tableId, int orderStatusId)
        {
            return _dao.GetOrdersByTableIdAndOrderStatusId(tableId, orderStatusId);
        }
        public void UpdateOrderStatus(Guid orderId, int orderStatusId)
        {
            try
            {
                Order o = _dao.GetOrderById(orderId);
                o.OrderStatusId = orderStatusId;
                _dao.UpdateOrder(o);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public float GetTotalPriceOfOrders(List<Order> orders)
        {
            float totalPrice = 0;

            foreach (var order in orders)
            {
                totalPrice += _dao.GetTotalAmmountOfOrder(order.Id);
            }

            return totalPrice;
        }
        public void UpdateBillIdOfOrder(Guid orderId, Guid billId)
        {
            Order order = _dao.GetOrderById(orderId);
            order.BillId = billId;
            _dao.UpdateOrder(order);
        }

        public List<Order> GetOrdersByBillId(Guid billId)
        {
            return _dao.GetOrdersByBillId(billId);
        }

        public List<Order> GetServedOrdersByTableId(Guid tableId)
        {
            return _dao.GetServedOrdersByTableId(tableId);
        }


        public IQueryable<Order> GetServingOrdersByTimeRange(DateTime date)
        {
            DateTime startDate = Ultilities.AbsoluteStart(date);
            DateTime endDate = Ultilities.AbsoluteEnd(date);

            return _dao.GetServingOrdersByTimeRange(startDate, endDate);
        }

        public IQueryable<Order> GetServedOrdersByTimeRange(DateTime date)
        {
            DateTime startDate = Ultilities.AbsoluteStart(date);
            DateTime endDate = Ultilities.AbsoluteEnd(date);

            return _dao.GetServedOrdersByTimeRange(startDate, endDate);
        }
        public IQueryable<Order> GetOrdersByTimeRange(DateTime date)
        {
            DateTime startDate = Ultilities.AbsoluteStart(date);
            DateTime endDate = Ultilities.AbsoluteEnd(date);
            return _dao.GetOrdersByTimeRange(startDate, endDate);
        }
    }
}
