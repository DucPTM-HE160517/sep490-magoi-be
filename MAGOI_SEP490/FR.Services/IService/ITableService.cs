using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface ITableService
    {
        List<Table> GetTables();
        List<Table> GetTablesByStatusId(int tableStatusId);
        Table GetTable(Guid id);
        Table GetTableByName(string name);
        void UpdateTableStatus(Guid tableId, TableStatusId statusId);
        void UpdateTableStatusWhenCreateOrder(Guid tableId);
    }
}
