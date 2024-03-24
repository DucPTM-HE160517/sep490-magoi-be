using FR.DataAccess;
using FR.Services.GraphQL.Types;
using FR.Services.IService;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public AverageFeedback GetFeedbacks(IFeedbackService feedbackService) => feedbackService.GetAverageFeedback();

    }
}
