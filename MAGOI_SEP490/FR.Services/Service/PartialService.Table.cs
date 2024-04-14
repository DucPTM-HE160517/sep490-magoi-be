using FR.BusinessObjects.Models;
using FR.DataAccess.UOW;
using FR.Infrastructure.Enums;
using FR.Services.IService;

namespace FR.Services.Service
{
    public partial class Service : ITableService
    {
        public async Task<IEnumerable<Table>> GetTables()
        {
            return await _uow.TableDAO.GetAllAsync();
        }

        public IQueryable<Table> GetTablesByStatusId(int tableStatusId)
        {
            return _uow.TableDAO.GetTablesByStatusId(tableStatusId);
        }

        public async Task<Table> GetTable(Guid id)
        {
            return await _uow.TableDAO.GetTableById(id);
        }

        public async Task<Table> GetTableByName(string name)
        {
            return await _uow.TableDAO.GetTableByName(name);
        }

        public async Task<Table> GetTableByBillId(Guid billId)
        {
            return await _uow.BillDAO.GetTableOfBill(billId);
        }

        public async Task<Table> UpdateTableStatus(Guid tableId, int tableStatusId)
        {
            Table table = await GetTable(tableId);
            table.StatusId = tableStatusId;
            _uow.TableDAO.Update(table);

            return table;
        }

        public async Task UpdateTableStatusWhenCreateOrderAsync(Guid tableId)
        {
            Table table = await GetTableAsync(tableId);
            if (table.StatusId == (int)TableStatusId.Available)
            {
                UpdateTableStatus(tableId, TableStatusId.Serving);
            }
        }
    }
}
