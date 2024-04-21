using FR.Services.GraphQL.Types;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public AverageFeedback GetFeedbacks(IFeedbackService feedbackService) 
            => feedbackService.GetAverageFeedback();
        public AverageFeedback GetFeedbacksByTime(IFeedbackService feedbackService, 
            DateTime startDate, DateTime endDate)
                                => feedbackService.GetAverageFeedbackByDate(startDate, endDate);
    }
}
