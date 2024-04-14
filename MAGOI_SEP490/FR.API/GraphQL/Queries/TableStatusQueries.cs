using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public async Task< IEnumerable<TableStatus>> GetAllTableStatus(ITableStatusService service) => await service.GetAllTableStatus();
    }
}
