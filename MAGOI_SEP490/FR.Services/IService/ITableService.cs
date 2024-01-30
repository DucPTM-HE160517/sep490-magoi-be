using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface ITableService
    {
        List<Table> GetTables();
        Table GetTable(Guid id);
        void UpdateTableStatus(Guid tableId, TableStatusId statusId);
        void UpdateTableStatusWhenCreateOrder(Guid tableId);
    }
}
