using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<Table> GetTables(ITableService service) => service.GetTables();
    }
}
