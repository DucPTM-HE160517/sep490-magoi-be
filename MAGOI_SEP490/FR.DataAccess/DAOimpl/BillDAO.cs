using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess.DAOimpl
{
    public class BillDAO : BaseDAO<Bill>, IBillDAO
    {
        public BillDAO(DBContext context) : base(context)
        {
        }

        public async Task<Table> GetTableOfBill(Guid billId)
        {
            Bill bill = await GetBillById(billId);
            Order order = _context.Orders.FirstOrDefault(o => o.BillId == billId);
            return await _context.Tables.FindAsync(order.TableId);
        }

        public async Task<Bill> GetBillById(Guid billId)
        {
            return await _context.Bills.FindAsync(billId);
        }

        public IQueryable<Bill> GetBillsByDate(DateTime date)
        {
            return _context.Bills.Where(b => b.CreatedAt.Date == date.Date);
        }

        public IQueryable<Bill> GetBillsByTimeRange(DateTime startDate, DateTime endDate)
        {
            return _context.Bills.Where(c => c.FinishedAt >= startDate && c.FinishedAt <= endDate);
        }
    }
}
