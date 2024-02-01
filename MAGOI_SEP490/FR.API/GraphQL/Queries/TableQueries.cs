using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<Table> GetTables(ITableService service) => service.GetTables();
        public Table GetTable(ITableService service, Guid? id = null, string? name = null)
        {
            if(id.HasValue)
            {
                return service.GetTable(id.Value);
            }
            else if (!String.IsNullOrEmpty(name))
            {
                return service.GetTableByName(name);
            }
            else
            {
                return new Table { Id = Guid.Empty, Name = "NOT FOUND!" };
            }
        }

    }
}
