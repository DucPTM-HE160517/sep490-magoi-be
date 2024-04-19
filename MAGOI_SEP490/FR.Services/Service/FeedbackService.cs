using System.Runtime.CompilerServices;
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
                feedback.Comment = comment ?? feedback.Comment;
                _dao.UpdateFeedback(feedback);
                return feedback;
            }
            else
            {
                Feedback feedback = new()
                {
                    Id = new Guid(),
                    BillId = new Guid(billId),
                    ServingScore = servingStar,
                    FoodScore = foodStar,
                    Comment = comment ?? ""
                };

                _dao.AddFeedback(feedback);
                return feedback;
            }
        }

        public AverageFeedback GetAverageFeedback()
        {
            AverageFeedback averageFeedback = new()
            {
                Feedbacks = GetFeedbacks()
            };

            averageFeedback.AverageServingScore = AverageServingScore(averageFeedback.Feedbacks);
            averageFeedback.AverageFoodScore = AverageFoodScore(averageFeedback.Feedbacks);

            Tuple<int[], int[]> feedbackScoreStats = GetFeedbackScoreStats(averageFeedback.Feedbacks);
            averageFeedback.ServingScoreStats = feedbackScoreStats.Item1;
            averageFeedback.FoodScoreStats = feedbackScoreStats.Item2;

            return averageFeedback;
        }

        public AverageFeedback GetAverageFeedbackByDate(DateTime startDate, DateTime endDate)
        {
            AverageFeedback averageFeedbackByDate = new()
            {
                Feedbacks = GetFeedbacksByDate(startDate, endDate)
            };

            averageFeedbackByDate.AverageServingScore = AverageServingScore(averageFeedbackByDate.Feedbacks);
            averageFeedbackByDate.AverageFoodScore = AverageFoodScore(averageFeedbackByDate.Feedbacks);

            Tuple<int[], int[]> feedbackScoreStats = GetFeedbackScoreStats(averageFeedbackByDate.Feedbacks);
            averageFeedbackByDate.ServingScoreStats = feedbackScoreStats.Item1;
            averageFeedbackByDate.FoodScoreStats = feedbackScoreStats.Item2;

            return averageFeedbackByDate;
        }

        public List<Feedback> GetFeedbacks() => _dao.GetFeedbacks();
        
        public List<Feedback> GetFeedbacksByDate(DateTime startDate, DateTime endDate) 
            => _dao.GetFeedbacksByDate(startDate, endDate);
        
        private static float AverageServingScore(List<Feedback> feedbacks) 
            => (float)(feedbacks.Count == 0 ? 
            0 : Math.Round(feedbacks.Select(f => f.ServingScore).Average(), 1));
        
        private static float AverageFoodScore(List<Feedback> feedbacks) 
            => (float)(feedbacks.Count == 0 ? 
            0 : Math.Round(feedbacks.Select(f => f.FoodScore).Average(), 1));

        private static Tuple<int[], int[]> GetFeedbackScoreStats(List<Feedback> feedbacks)
        {
            int[] servingScoreStats = new int[5] { 0, 0, 0, 0, 0 };
            int[] foodScoreStats = new int[5] { 0, 0, 0, 0, 0 };

            foreach (var feedback in feedbacks)
            {
                servingScoreStats[feedback.ServingScore - 1]++;
                foodScoreStats[feedback.FoodScore - 1]++;
            }

            return new Tuple<int[], int[]>(servingScoreStats, foodScoreStats);
        }
    }
}
