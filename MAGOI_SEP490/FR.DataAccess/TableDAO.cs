using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.DataAccess
{
    public class TableDAO
    {
        private readonly DBContext _context;
        private readonly OrderDAO _orderDAO;
        public TableDAO(DBContext context)
        {
            _context = context;
        }

        public List<Table> GetTables()
        {
            return _context.Tables.ToList();
        }
        public List<Table> GetTablesByStatusId(int tableStatusId)
        {
            return _context.Tables.Where(t => t.StatusId == tableStatusId).ToList();
        }
        public Table GetTable(Guid id)
        {
            return _context.Tables.SingleOrDefault(table => table.Id.Equals(id));
        }
        public Table GetTableByName(string name)
        {
            return _context.Tables.FirstOrDefault(table => table.Name.Equals(name));
        }
        public void UpdateTableStatus(Guid tableId, TableStatusId statusId)
        {
            Table table = GetTable(tableId);
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
