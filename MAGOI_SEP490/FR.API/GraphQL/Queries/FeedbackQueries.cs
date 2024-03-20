using FR.API.GraphQL.Types;
using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.IService;
using FR.Services.Service;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public FeedbacksWithAverage GetFeedbacks(IFeedbackService feedbackService) => feedbackService.GetFeedbacksWithAverage();

    }
}
