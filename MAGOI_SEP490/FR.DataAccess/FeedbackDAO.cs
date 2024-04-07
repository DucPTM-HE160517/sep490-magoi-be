﻿using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.DataAccess
{
    public class FeedbackDAO
    {
        private readonly DBContext _context;
        public FeedbackDAO(DBContext context)
        {
            _context = context;
        }

        public IQueryable<Feedback> GetFeedbacks() => _context.Feedbacks;
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
