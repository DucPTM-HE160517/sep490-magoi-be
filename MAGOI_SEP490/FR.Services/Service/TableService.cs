using FR.BusinessObjects.Models;
using FR.DataAccess.DAO;
using FR.DataAccess.DAOimpl;
using FR.DataAccess.UOW;
using FR.Infrastructure.Enums;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.Services.Service
{
    public class TableService : ITableService
    {
        private readonly ITableDAO _dao;
        private readonly IUnitOfWork _uow;
        public TableService(IUnitOfWork uow)
        {
            _uow = uow;
            _dao = ((UnitOfWork)uow).Table;
        }
        public async Task<List<Table>> GetTablesAsync()
        {
            return (List<Table>)await _dao.GetAllAsync();
        }

        public async Task<List<Table>> GetTablesByStatusIdAsync(int tableStatusId)
        {
            return await _dao.GetTablesByStatusId(tableStatusId).ToListAsync();
        }

        public async Task<Table> GetTableAsync(Guid id)
        {
            return await _dao.GetTableById(id);
        }

        public async Task<Table> GetTableByNameAsync(string name)
        {
            return await _dao.GetTableByName(name);
        }

        public async Task<Table> GetTableByBillIdAsync(Guid billId)
        {
            return await _dao.GetTableByBillId(billId);
        }

        public async Task UpdateTableStatusAsync(Guid tableId, TableStatusId statusId)
        {
           _dao.UpdateTableStatus(tableId, statusId);
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
