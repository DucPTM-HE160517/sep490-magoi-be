using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface ITableService
    {
        List<Table> GetTables();
        Table GetTable(int id);
        void UpdateTableStatus(int tableId, TableStatusId statusId);
    }
}
