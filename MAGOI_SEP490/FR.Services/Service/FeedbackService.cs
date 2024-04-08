using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.GraphQL.Types;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class FeedbackService : IFeedbackService
    {
        private readonly FeedbackDAO _dao;

        public FeedbackService()
        {
        }

        public FeedbackService(FeedbackDAO dao)
        {
            _dao = dao;
        }

        public Feedback CreateFeedback(string billId, int servingStar, int foodStar, string? comment)
        {
            try
            {
                Feedback newFeedback = new Feedback()
                {
                    Id = new Guid(),
                    BillId = Guid.Parse(billId),
                    ServingScore = servingStar,
                    FoodScore = foodStar,
                    Comment = comment == null ? "" : comment
                };

                //Check if bill already has feedback
                Feedback fb = _dao.GetFeedbacks().Where(f => f.BillId == newFeedback.BillId).FirstOrDefault();

                if (fb != null)
                {
                    newFeedback.Id = fb.Id;
                    int updateStatus = _dao.UpdateFeedback(fb,newFeedback);
                    if (updateStatus == 0)
                    {
                        return null;
                    }
                }
                else
                {
                    _dao.AddFeedback(newFeedback);
                }
                               
                return newFeedback;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public AverageFeedback GetAverageFeedback()
        {
            AverageFeedback averageFeedback = new AverageFeedback()
            {
                Feedbacks = GetFeedbacks()
            };

            averageFeedback.AverageServingScore = AverageServingScore(averageFeedback.Feedbacks);
            averageFeedback.AverageFoodScore = AverageFoodScore(averageFeedback.Feedbacks);
            return averageFeedback;
        }

        public AverageFeedback GetAverageFeedbackByDate(DateTime startDate, DateTime endDate)
        {
            AverageFeedback averageFeedbackByDate = new AverageFeedback()
            {
                Feedbacks = GetFeedbacksByDate(startDate, endDate)
            };
            averageFeedbackByDate.AverageServingScore = AverageServingScore(averageFeedbackByDate.Feedbacks);
            averageFeedbackByDate.AverageFoodScore = AverageFoodScore(averageFeedbackByDate.Feedbacks);
            return averageFeedbackByDate;
        }

        public List<Feedback> GetFeedbacks() => _dao.GetFeedbacks();
        public List<Feedback> GetFeedbacksByDate(DateTime startDate, DateTime endDate) => _dao.GetFeedbacksByDate(startDate, endDate);
        public float AverageServingScore(List<Feedback> feedbacks) => (float)(feedbacks.Count == 0 ? 0 : Math.Round(feedbacks.Select(f => f.ServingScore).Average(), 1));
        public float AverageFoodScore(List<Feedback> feedbacks) => (float)(feedbacks.Count == 0 ? 0 : Math.Round(feedbacks.Select(f => f.FoodScore).Average(), 1));

    }
}
