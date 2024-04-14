using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;

namespace FR.Services.Service
{
    public partial class Service : IFeedbackService
    {
        public async Task<Feedback> CreateFeedback(string billId, int servingStar, int foodStar, string? comment)
        {
            if (await _uow.FeedbackDAO.IsExist(Guid.Parse(billId)))
            {
                Feedback feedback = await _uow.FeedbackDAO.GetFeedbackByBillId(Guid.Parse(billId));
                feedback.ServingScore = servingStar;
                feedback.FoodScore = foodStar;
                feedback.Comment = comment == null ? feedback.Comment : comment;
                _uow.FeedbackDAO.Update(feedback);
                await _uow.SaveAsync();
                _uow.Dispose();
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

                await _uow.FeedbackDAO.AddAsync(feedback);
                await _uow.SaveAsync();
                _uow.Dispose();
                return feedback;
            }
        }

        public async Task<AverageFeedback> GetAverageFeedback()
        {
            AverageFeedback averageFeedback = new AverageFeedback()
            {
                Feedbacks = (await GetFeedbacks()).ToList()
            };

            averageFeedback.AverageServingScore = AverageServingScore(averageFeedback.Feedbacks);
            averageFeedback.AverageFoodScore = AverageFoodScore(averageFeedback.Feedbacks);
            return averageFeedback;
        }

        public async Task<AverageFeedback> GetAverageFeedbackByDate(DateTime startDate, DateTime endDate)
        {
            AverageFeedback averageFeedbackByDate = new AverageFeedback()
            {
                Feedbacks = await GetFeedbacksByDate(startDate, endDate)
            };
            averageFeedbackByDate.AverageServingScore = AverageServingScore(averageFeedbackByDate.Feedbacks);
            averageFeedbackByDate.AverageFoodScore = AverageFoodScore(averageFeedbackByDate.Feedbacks);
            return averageFeedbackByDate;
        }

        public async Task<IEnumerable<Feedback>> GetFeedbacks() => await _uow.FeedbackDAO.GetAllAsync();
        public async Task<List<Feedback>> GetFeedbacksByDate(DateTime startDate, DateTime endDate) => await _uow.FeedbackDAO.GetFeedbacks(startDate, endDate).ToListAsync();
        public float AverageServingScore(List<Feedback> feedbacks) => (float)(feedbacks.Count == 0 ? 0 : Math.Round(feedbacks.Select(f => f.ServingScore).Average(), 1));
        public float AverageFoodScore(List<Feedback> feedbacks) => (float)(feedbacks.Count == 0 ? 0 : Math.Round(feedbacks.Select(f => f.FoodScore).Average(), 1));

    }
}
