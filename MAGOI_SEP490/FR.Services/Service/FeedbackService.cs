using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.GraphQL.Types;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class FeedbackService : IFeedbackService
    {
        private readonly FeedbackDAO _dao;

        public FeedbackService(FeedbackDAO dao)
        {
            _dao = dao;
        }

        public async Task<Feedback> CreateFeedback(string billId, int servingStar, int foodStar, string? comment)
        {
            if (await _dao.IsExist(Guid.Parse(billId)))
            {
                Feedback feedback = _dao.GetFeedbackByBillId(Guid.Parse(billId));
                feedback.ServingScore = servingStar;
                feedback.FoodScore = foodStar;
                feedback.Comment = comment == null ? feedback.Comment : comment;
                _dao.UpdateFeedback(feedback);
                return feedback;
            }
            else
            {
                Feedback feedback = new Feedback()
                {
                    Id = new Guid(),
                    BillId = new Guid(billId),
                    ServingScore = servingStar,
                    FoodScore = foodStar,
                    Comment = comment == null ? "" : comment
                };

                _dao.AddFeedback(feedback);
                return feedback;
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
