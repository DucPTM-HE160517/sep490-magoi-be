using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess.DAOimpl
{
    public class FeedbackDAO : BaseDAO<Feedback>, IFeedbackDAO
    {
        public FeedbackDAO(DBContext context) : base(context)
        {
        }

        public async Task<bool> IsExist(Guid billId)
        {
            return await _context.Feedbacks.AnyAsync(f => f.BillId == billId);
        }
        public async Task<Feedback> GetFeedbackById(Guid id)
        {
            return await _context.Feedbacks.FindAsync(id);
        }
        public async Task<Feedback> GetFeedbackByBillId(Guid id)
        {
            return await _context.Feedbacks.SingleOrDefaultAsync(c => c.BillId == id);
        }
        public IQueryable<Feedback> GetFeedbacks(DateTime startDate, DateTime endDate)

        {
            List<Feedback> list = new List<Feedback>();

            try
            {
                foreach (Feedback feedback in _context.Feedbacks.ToList())
                {
                    foreach (Bill bill in _context.Bills.ToList())
                    {
                        if (feedback.BillId == bill.Id)
                        {
                            if (bill.FinishedAt != null && bill.FinishedAt >= startDate && bill.FinishedAt <= endDate)
                            {
                                list.Add(feedback);
                            }
                        }
                    }
                }

                return list.AsQueryable();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
