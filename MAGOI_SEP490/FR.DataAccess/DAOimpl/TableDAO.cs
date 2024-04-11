using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;
using FR.Infrastructure.Enums;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess.DAOimpl
{
    public class TableDAO : BaseDAO<Table>, ITableDAO
    {
        public TableDAO(DBContext context) : base(context)
        {
        }
        public async Task<Table> GetTableById(Guid id)
        {
            return await _context.Tables.FindAsync(id);
        }

        public async Task<Table> GetTableByName(string name)
        {
            return await _context.Tables.SingleOrDefaultAsync(table => table.Name.Equals(name));
        }

        public IQueryable<Table> GetTablesByStatusId(int tableStatusId)
        {
            return _context.Tables.Where(t => t.StatusId == tableStatusId);
        }

        public async Task<bool> IsExist(string name)
        {
            return await _context.Tables.AnyAsync(t => t.Name == name);
        }

        //public List<Table> GetTables()
        //{
        //    return _context.Tables.ToList();
        //}
        //public List<Table> GetTablesByStatusId(int tableStatusId)
        //{
        //    return _context.Tables.Where(t => t.StatusId == tableStatusId).ToList();
        //}
        //public Table GetTable(Guid id)
        //{
        //    return _context.Tables.SingleOrDefault(table => table.Id.Equals(id));
        //}
        //public Table GetTableByName(string name)
        //{
        //    return _context.Tables.FirstOrDefault(table => table.Name.Equals(name));
        //}
        //public void UpdateTableStatus(Guid tableId, TableStatusId statusId)
        //{
        //    Table table = GetTable(tableId);
        //    table.StatusId = (int)statusId;
        //    _context.SaveChanges();
        //}
        //public Table GetTableByBillId(Guid billId)
        //{
        //    Order order = _context.Orders.FirstOrDefault(o => o.BillId == billId);
        //    return _context.Tables.SingleOrDefault(t => t.Id == order.TableId);
        //}
    }
}
