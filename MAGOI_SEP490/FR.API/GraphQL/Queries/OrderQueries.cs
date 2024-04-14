using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public IQueryable<Order> GetOrdersByStatusID(IOrderService service,int? statusID) 
            => service.GetOrdersByOrderStatusId(statusID);

        public async Task<Order> GetOrderById(IOrderService service, Guid orderId) 
            => await service.GetOrderById(orderId);     

    }
}
