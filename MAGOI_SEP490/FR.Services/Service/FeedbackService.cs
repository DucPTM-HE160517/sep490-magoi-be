using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.GraphQL.Types;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class FeedbackService : IFeedbackService
    {
        private readonly FeedbackDAO _dao;

        public FeedbackService()
        {
        }

        public FeedbackService(FeedbackDAO dao)
        {
            _dao = dao;
        }

        public Feedback CreateFeedback(string billId, int servingStar, int foodStar, string? comment)
        {
            try
            {
                Feedback feedback = new Feedback()
                {
                    Id = new Guid(),
                    BillId = new Guid(billId),
                    ServingScore = servingStar,
                    FoodScore = foodStar,
                    Comment = comment == null ? "" : comment
                };

                _dao.AddFeedback(feedback);
                return feedback;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public AverageFeedback GetAverageFeedback()
        {
            return new AverageFeedback() 
            {
                AverageFoodScore = _dao.AverageFoodScore(),
                AverageServingScore = _dao.AverageServingScore(),
                Feedbacks = GetFeedbacks()
            };
        }

        public List<Feedback> GetFeedbacks() => _dao.GetFeedbacks();

    }
}
