using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface IFeedbackService
    {
        List<Feedback> GetFeedbacks();
        Feedback CreateFeedback(string billId, int servingStar, int foodStar, string? comment);
        //AverageFeedback GetAverageFeedback();
    }
}
