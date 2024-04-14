using FR.BusinessObjects.Models;
using FR.Infrastructure.Enums;

namespace FR.Services.IService
{
    public interface ITableService
    {
        Task<IEnumerable<Table>> GetTables();
        IQueryable<Table> GetTablesByStatusId(int tableStatusId);
        Task<Table> GetTable(Guid id);
        Task<Table> GetTableByName(string name);
        Task<Table> GetTableByBillId(Guid billId);
        Task UpdateTableStatus(Guid tableId, int tableStatusId);
        Task UpdateTableStatusWhenCreateOrder(Guid tableId);
    }
}
