using FR.BusinessObjects.DataContext;
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

        public int UpdateFeedback(Feedback oldFeedback, Feedback newFeedback)
        {
            int statusCode = 1;
            try
            {
                var existingFeedback = _context.Feedbacks.Find(oldFeedback.Id);

                if (existingFeedback != null)
                {
                    //Update ServingScore
                    if (existingFeedback.ServingScore != newFeedback.ServingScore)
                    {
                        existingFeedback.ServingScore = newFeedback.ServingScore;
                    }

                    //Update FoodScore
                    if (existingFeedback.FoodScore != newFeedback.FoodScore)
                    {
                        existingFeedback.FoodScore = newFeedback.FoodScore;
                    }

                    //Update Comment
                    if (!string.IsNullOrEmpty(existingFeedback.Comment) && !string.IsNullOrEmpty(newFeedback.Comment))
                    {
                        //Check Duplicate
                        if (existingFeedback.Comment == newFeedback.Comment && existingFeedback.ServingScore == newFeedback.ServingScore 
                            && existingFeedback.FoodScore == newFeedback.FoodScore)
                        {
                            return 0;
                        }

                        //Update Comment
                        if (existingFeedback.Comment != newFeedback.Comment)
                        {
                            existingFeedback.Comment = newFeedback.Comment;
                        }
                    }
                    else if (!string.IsNullOrEmpty(newFeedback.Comment) && string.IsNullOrEmpty(existingFeedback.Comment)) //Check case: new Comment
                    {
                        existingFeedback.Comment = newFeedback.Comment;
                    }
                    else if (string.IsNullOrEmpty(newFeedback.Comment) && !string.IsNullOrEmpty(existingFeedback.Comment)) //Check case: delete Comment
                    {
                        existingFeedback.Comment = "";
                    }
                    else
                    {
                        //Check Duplicate with no Comment
                        if (existingFeedback.ServingScore == newFeedback.ServingScore && existingFeedback.FoodScore == newFeedback.FoodScore)
                        {
                            return 0;
                        }
                    }

                    _context.SaveChanges();
                }                

                return statusCode;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
