using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class FeedbackService : IFeedbackService
    {
        private readonly FeedbackDAO _dao;
        public FeedbackService(FeedbackDAO dao)
        {
            _dao = dao;
        }

        public float AverageFoodScore() => _dao.AverageFoodScore();

        public float AverageServingScore() => _dao.AverageServingScore();

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

        public List<Feedback> GetFeedbacks() => _dao.GetFeedbacks();
    }
}
