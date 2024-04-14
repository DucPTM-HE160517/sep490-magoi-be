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
            switch (tableStatusId)
            {
                case null:
                    return (await service.GetTables()).ToList();
                case (int)TableStatusId.Available:
                    return await service.GetTablesByStatusId((int)TableStatusId.Available).ToListAsync();
                case (int)TableStatusId.Serving:
                    return await service.GetTablesByStatusId((int)TableStatusId.Serving).ToListAsync();
                case (int)TableStatusId.Booked:
                    return await service.GetTablesByStatusId((int)TableStatusId.Booked).ToListAsync();
                default:
                    return new List<Table>();
            }
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
