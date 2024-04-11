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
        async Task<Bill> IBillDAO.GetBillById(Guid billId)
        {
            return await _context.Bills.FindAsync(billId);
        }

        IQueryable<Bill> IBillDAO.GetBillsByDate(DateTime date)
        {
            return _context.Bills.Where(b => b.CreatedAt.Date == date.Date);
        }

        IQueryable<Bill> IBillDAO.GetBillsByTimeRange(DateTime startDate, DateTime endDate)
        {
            return _context.Bills.Where(c => c.FinishedAt >= startDate && c.FinishedAt <= endDate);
        }
    }
}
