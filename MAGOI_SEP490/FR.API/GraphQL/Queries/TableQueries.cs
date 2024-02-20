using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public List<Table> GetTables(ITableService service, int? tableStatusId = null)
        {
            switch (tableStatusId)
            {
                case null:
                    return service.GetTables();
                case (int)TableStatusId.Available:
                    return service.GetTablesByStatusId((int)TableStatusId.Available);
                case (int)TableStatusId.Serving:
                    return service.GetTablesByStatusId((int)TableStatusId.Serving);
                case (int)TableStatusId.Booked:
                    return service.GetTablesByStatusId((int)TableStatusId.Booked);
                default:
                    return new List<Table>();
            }
        }
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
