using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutation
    {
        public async Task<String> SendFeedback(
            IFeedbackService feedbackService,
            IBillService billService,
            string billId, int servingStar, int foodStar, string? comment)
        {
            try
            {
                //create feedback
                Feedback feedback = feedbackService.CreateFeedback(billId, servingStar, foodStar, comment);
                //update feedbackid of bill
                billService.UpdateBillFeedback(Guid.Parse(billId), feedback.Id);
                return "Feedback sent!";
            }
            catch(Exception e)
            {
                return "Error!" + e.Message;
            }
        }
    }
}
