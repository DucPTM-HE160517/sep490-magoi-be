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

        //public void AddBill(Bill bill)
        //{
        //    _context.Bills.Add(bill);
        //    _context.SaveChanges();
        //}
        //public void UpdateBill(Bill bill)
        //{
        //    _context.Entry(bill).State = EntityState.Modified;
        //    _context.SaveChanges();
        //}
        //public Bill GetBillById(Guid billId)
        //{
        //    return _context.Bills.SingleOrDefault(b => b.Id == billId);
        //}
        //public List<Bill> GetBillsByDate(DateTime date)
        //{
        //    return _context.Bills.Where(b => b.CreatedAt.Date == date.Date).ToList();
        //}
        //public List<Bill> GetBillsByTimeRange(DateTime startDate, DateTime endDate)
        //{
        //    return _context.Bills.Where(c => c.FinishedAt >= startDate && c.FinishedAt <= endDate).ToList();
        //}

        Task<Bill> IBillDAO.GetBillById(Guid id)
        {
            throw new NotImplementedException();
        }

        IQueryable<Bill> IBillDAO.GetBillsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        IQueryable<Bill> IBillDAO.GetBillsByTimeRange(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
