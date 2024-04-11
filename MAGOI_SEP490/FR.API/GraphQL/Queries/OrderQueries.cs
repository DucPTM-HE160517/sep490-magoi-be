using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<Order> GetOrdersByStatusID(IOrderService service,int? statusID) 
            => service.GetOrdersByOrderStatusId(statusID);
        public IQueryable<Order> GetOrdersByStatusAndDate(IOrderService service,
            int statusID, DateTime startDate, DateTime endDate) 
            => service.GetOrdersByStatusAndDate(statusID, startDate, endDate);
        public Order GetOrderById(IOrderService service, Guid orderId) 
            => service.GetOrderById(orderId);     

    }
}
