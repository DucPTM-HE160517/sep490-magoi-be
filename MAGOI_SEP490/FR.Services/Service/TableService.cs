using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Infrastructure.Enums;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class TableService : ITableService
    {
        private readonly TableDAO _dao;
        public TableService(TableDAO dao)
        {
            _dao = dao;
        }

        public IQueryable<Table> GetTables()
        {
            return _dao.GetTables();
        }

        public async Task<Table> GetTable(Guid id)
        {
            return await _dao.GetTable(id);
        }

        public void UpdateTableStatus(Guid tableId, TableStatusId statusId)
        {
            _dao.UpdateTableStatus(tableId, statusId);
        }

        public async void UpdateTableStatusWhenCreateOrder(Guid tableId)
        {
            Table table = await GetTable(tableId);
            if (table.StatusId == (int)TableStatusId.Available)
            {
                UpdateTableStatus(tableId, TableStatusId.Serving);
            }
        }

        public Table GetTableByName(string name)
        {
            return _dao.GetTableByName(name);
        }

        public IQueryable<Table> GetTablesByStatusId(int tableStatusId)
        {
            return _dao.GetTablesByStatusId(tableStatusId);
        }

        public Table GetTableByBillId(Guid billId)
        {
            return _dao.GetTableByBillId(billId);
        }
    }
}
