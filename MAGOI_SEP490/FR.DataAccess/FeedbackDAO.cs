using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess
{
    public class FeedbackDAO
    {
        private readonly DBContext _context;
        public FeedbackDAO(DBContext context)
        {
            _context = context;
        }

        public List<Feedback> GetFeedbacks() => _context.Feedbacks.ToList();

        public void AddFeedback(Feedback feedback)
        {
            try
            {
                _context.Feedbacks.Add(feedback);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //public float AverageServingScore()
        //{
        //    return _context.Feedbacks.Count() == 0 ? 0 : (float)_context.Feedbacks.Select(f => f.ServingScore).Average();
        //}

        //public float AverageFoodScore()
        //{
        //    return _context.Feedbacks.Count() == 0 ? 0 : (float)_context.Feedbacks.Select(f => f.FoodScore).Average();
        //}
        public Feedback GetFeedbackById(Guid id)
        {
            return _context.Feedbacks.SingleOrDefault(c => c.Id == id);
        }
        public List<Feedback> GetFeedbacksByDate(DateTime startDate, DateTime endDate)
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
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
