using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.GraphQL.Types;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public AverageFeedback GetAverageFeedback(IFeedbackService feedbackService) => feedbackService.GetAverageFeedback();

        public List<Feedback> GetFeedbacks(IFeedbackService feedbackService) => feedbackService.GetFeedbacks();

    }
}
