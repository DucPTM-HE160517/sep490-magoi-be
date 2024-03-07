using FR.API.GraphQL.Payload;
using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async Task<SendFeedbackPayload> SendFeedback(
            IFeedbackService feedbackService,
            IBillService billService,
            string billId, int servingStar, int foodStar, string? comment)
        {
            try
            {
                //create feedback
                Feedback feedback = feedbackService.CreateFeedback(billId, servingStar, foodStar, comment);
                return new SendFeedbackPayload(feedback);
            }
            catch(Exception ex)
            {
                return new SendFeedbackPayload((new UserError("ERROR: " + ex.Message, "ERROR_CODE")));
            }
        }
    }
}
