using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.GraphQL.InputTypes;
using FR.Services.IService;

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
                CreatedAt = orderInput.createdAt
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
    }
}
