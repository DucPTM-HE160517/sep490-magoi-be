using FR.BusinessObjects.Models;
using FR.Services.GraphQL.Payload;
using FR.Services.GraphQL.Payload.Errors;
using FR.Services.IService;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async Task<Payloadd<Feedback>> SendFeedback(
            IFeedbackService feedbackService,
            string billId, int servingStar, int foodStar, string? comment)
        {
            if (servingStar < 1 || servingStar > 5 
                || foodStar < 1 || foodStar > 5 
                || !Guid.TryParse(billId, out _)) 
            {
                return new Payloadd<Feedback>(Errors.Feedback.InvalidInput);
            }

            //create feedback
            Feedback feedback = await feedbackService.CreateFeedback(billId, servingStar, foodStar, comment);

            return new Payloadd<Feedback>(feedback);
        }
    }
}
