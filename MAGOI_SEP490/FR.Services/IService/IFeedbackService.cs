using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;

namespace FR.Services.IService
{
    public interface IFeedbackService
    {
        IQueryable<Feedback> GetFeedbacks();
        Feedback CreateFeedback(string billId, int servingStar, int foodStar, string? comment);
        Task<AverageFeedback> GetAverageFeedback();
        Task<AverageFeedback> GetAverageFeedbackByDate(DateTime startDate, DateTime endDate);
    }
}
