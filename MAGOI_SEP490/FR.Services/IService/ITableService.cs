using FR.BusinessObjects.Models;
using FR.Infrastructure.Enums;

namespace FR.Services.IService
{
    public interface ITableService
    {
        IQueryable<Table> GetTables();
        IQueryable<Table> GetTablesByStatusId(int tableStatusId);
        Task<Table> GetTable(Guid id);
        Table GetTableByName(string name);
        Table GetTableByBillId(Guid billId);
        void UpdateTableStatus(Guid tableId, TableStatusId statusId);
        void UpdateTableStatusWhenCreateOrder(Guid tableId);
    }
}
