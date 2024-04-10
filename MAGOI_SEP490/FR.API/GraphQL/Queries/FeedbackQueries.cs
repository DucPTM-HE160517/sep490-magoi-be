using FR.DataAccess;
using FR.Services.GraphQL.Types;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public async Task<AverageFeedback> GetFeedbacks(IFeedbackService feedbackService) => await feedbackService.GetAverageFeedback();
        public async Task<AverageFeedback> GetFeedbacksByTime(IFeedbackService feedbackService, DateTime startDate, DateTime endDate)
                                => await feedbackService.GetAverageFeedbackByDate(startDate, endDate);
    }
}
