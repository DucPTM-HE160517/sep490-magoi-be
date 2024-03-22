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

        public float AverageServingScore()
        {
            return _context.Feedbacks.Count() == 0 ? 0 : (float)_context.Feedbacks.Select(f => f.ServingScore).Average();
        }

        public float AverageFoodScore()
        {
            return _context.Feedbacks.Count() == 0 ? 0 : (float)_context.Feedbacks.Select(f => f.FoodScore).Average();
        }
        public FeedbacksWithAverage GetFeedbacksWithAverage()
        {
            FeedbacksWithAverage feedbacks = new FeedbacksWithAverage()
            {
                AverageServingScore = AverageFoodScore(),
                AverageFoodScore = AverageServingScore(),
                Feedbacks = GetFeedbacks()
            };

            return feedbacks;
        }
    }
    public class FeedbacksWithAverage
    {
        public float AverageServingScore { get; set; }
        public float AverageFoodScore { get; set; }
        public List<Feedback> Feedbacks { get; set; }
    }
}
