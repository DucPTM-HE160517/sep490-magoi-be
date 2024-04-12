using FR.BusinessObjects.Models;
using FR.Infrastructure.Enums;

namespace FR.Services.IService
{
    public interface ITableService
    {
        Task<List<Table>> GetTablesAsync();
        Task<List<Table>> GetTablesByStatusIdAsync(int tableStatusId);
        Task<Table> GetTableAsync(Guid id);
        Task<Table> GetTableByNameAsync(string name);
        Task<Table> GetTableByBillIdAsync(Guid billId);
        Task UpdateTableStatusAsync(Guid tableId, TableStatusId statusId);
        Task UpdateTableStatusWhenCreateOrderAsync(Guid tableId);
    }
}
