using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess
{
    public class BillDAO
    {
        private readonly DBContext _context;
        public BillDAO(DBContext context)
        {
            _context = context;
        }
        public void AddBill(Bill bill)
        {
            _context.Bills.Add(bill);
            _context.SaveChanges();
        }
        public void UpdateBill(Bill bill)
        {
            _context.Entry(bill).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public async Task<Bill> GetBillById(Guid billId)
        {
            return await _context.Bills.SingleOrDefaultAsync(b => b.Id == billId);
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
