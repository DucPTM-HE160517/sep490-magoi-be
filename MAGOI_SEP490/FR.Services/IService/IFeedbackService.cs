using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Types;

namespace FR.Services.IService
{
    public interface IFeedbackService
    {
        List<Feedback> GetFeedbacks();
        Feedback CreateFeedback(string billId, int servingStar, int foodStar, string? comment);
        AverageFeedback GetAverageFeedback();
        AverageFeedback GetAverageFeedbackByDate(DateTime startDate, DateTime endDate);
    }
}
