using FR.BusinessObjects.Models;
using FR.DataAccess;
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

        public void AddOrder(Order order)
        {
            try
            {
                _dao.AddOrder(order);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Order GetOrderById(int Id)
        {
            return _dao.GetOrderById(Id);
        }
    }
}
