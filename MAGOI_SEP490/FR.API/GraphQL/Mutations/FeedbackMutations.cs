using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Payload;
using FR.Services.IService;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async Task<Feedback> SendFeedback(
            IFeedbackService feedbackService,
            string billId, int servingStar, int foodStar, string? comment)
        => await feedbackService.CreateFeedback(billId, servingStar, foodStar, comment);
    }
}
