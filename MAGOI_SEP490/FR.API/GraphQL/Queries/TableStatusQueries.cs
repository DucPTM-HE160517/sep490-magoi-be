using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class TableStatusQueries
    {
        public List<TableStatus> GetAllTableStatus(ITableStatusService service) => service.GetAllTableStatus();
    }
}
