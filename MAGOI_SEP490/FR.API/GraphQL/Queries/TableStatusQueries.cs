using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public IQueryable<TableStatus> GetAllTableStatus(ITableStatusService service) => service.GetAllTableStatus();
    }
}
