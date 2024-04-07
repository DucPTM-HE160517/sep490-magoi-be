using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.Infrastructure.Enums;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess
{
    public class TableDAO
    {
        private readonly DBContext _context;
        public TableDAO(DBContext context)
        {
            _context = context;
        }
        public IQueryable<Table> GetTables()
        {
            return _context.Tables;
        }
        public IQueryable<Table> GetTablesByStatusId(int tableStatusId)
        {
            return _context.Tables.Where(t => t.StatusId == tableStatusId);
        }
        public async Task<Table> GetTable(Guid id)
        {
            return await _context.Tables.SingleOrDefaultAsync(table => table.Id.Equals(id));
        }
        public Table GetTableByName(string name)
        {
            return _context.Tables.FirstOrDefault(table => table.Name.Equals(name));
        }
        public async Task UpdateTableStatus(Guid tableId, TableStatusId statusId)
        {
            Table table = await GetTable(tableId);
            table.StatusId = (int)statusId;
            _context.SaveChanges();
        }
        public Table GetTableByBillId(Guid billId)
        {
            Order order = _context.Orders.FirstOrDefault(o => o.BillId == billId);
            return _context.Tables.SingleOrDefault(t => t.Id == order.TableId);
        }
    }
}
