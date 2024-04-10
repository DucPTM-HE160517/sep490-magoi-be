using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;

namespace FR.Services.IService
{
    public interface IFeedbackService
    {
        Task<IEnumerable<Feedback>> GetFeedbacks();
        Task<Feedback> CreateFeedback(string billId, int servingStar, int foodStar, string? comment);
        Task<AverageFeedback> GetAverageFeedback();
        Task<AverageFeedback> GetAverageFeedbackByDate(DateTime startDate, DateTime endDate);
    }
}
