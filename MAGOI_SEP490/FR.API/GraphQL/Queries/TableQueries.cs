using FR.BusinessObjects.Models;
using FR.Infrastructure.Enums;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public async Task<List<Table>> GetTables(ITableService service, int? tableStatusId = null)
        {
            return tableStatusId switch
            {
                null 
                    => (await service.GetTables()).ToList(),
                (int)TableStatusId.Available 
                    => await service.GetTablesByStatusId((int)TableStatusId.Available).ToListAsync(),
                (int)TableStatusId.Serving 
                    => await service.GetTablesByStatusId((int)TableStatusId.Serving).ToListAsync(),
                (int)TableStatusId.Booked 
                    => await service.GetTablesByStatusId((int)TableStatusId.Booked).ToListAsync(),
                _ 
                    => new List<Table>(),
            };
        }
        public async Task<Table> GetTable(ITableService service, Guid? id = null)
        {
            if(id.HasValue)
            {
                return await service.GetTable(id.Value);
            }
            else
            {
                return new Table { Id = Guid.Empty, Name = "NOT FOUND!" };
            }
        }

    }
}
