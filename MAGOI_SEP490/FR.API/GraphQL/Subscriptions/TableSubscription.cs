using FR.API.GraphQL.Mutations;
using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Subscriptions
{
    public partial class Subscriptions
    {
        [Subscribe]
        [Topic(nameof(Mutation.AddOrder))]
        public List<Table> OnAddOrder([EventMessage] Order order, ITableService tableService)
        {
            return tableService.GetTablesByStatusId((int)TableStatusId.Serving);
        }
    }
}
