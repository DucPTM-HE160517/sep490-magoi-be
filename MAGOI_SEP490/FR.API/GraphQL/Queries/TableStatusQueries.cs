using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<TableStatus> GetAllTableStatus(ITableStatusService service) 
            => service.GetAllTableStatus();
    }
}
