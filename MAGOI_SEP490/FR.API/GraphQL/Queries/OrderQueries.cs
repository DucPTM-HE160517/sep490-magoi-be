using FR.BusinessObjects.Models;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public IQueryable<Order> GetOrdersByStatusID(IOrderService service,int statusID) => service.GetOrdersByOrderStatusId(statusID);

        public Order GetOrderById(IOrderService service, Guid orderId) => service.GetOrderById(orderId).Result;     

    }
}
