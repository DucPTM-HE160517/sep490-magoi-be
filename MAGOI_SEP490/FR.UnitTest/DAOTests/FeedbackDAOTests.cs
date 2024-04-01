using FR.BusinessObjects.Models;
using FR.UnitTest;

namespace FR.UnitTests.DAOTests
{
    public class FeedbackDAOTests : BaseTest
    {
        public FeedbackDAOTests() : base() { }

        [OneTimeTearDown]
        public void Clean()
        {
            context.Database.EnsureDeleted();
        }

        [Test]
        public void GetFeedbackById_WhenCalled_ReturnsFeedback()
        {
            Guid FEEDBACK_ID = Guid.Parse("f8151278-a0d5-4dac-bb63-4ffdfa62affb");
            var feedback = feedbackDAO.GetFeedbackById(FEEDBACK_ID);

            Assert.That(feedback, Is.Not.Null);
        }

        [Test]
        public void AddFeedback_WhenCalled_AddsFeedback()
        {
            var feedback = new Feedback
            {
                Id = Guid.Parse("f120a375-b3d9-42c7-a633-28a38e9912db"),
                BillId = Guid.Parse("ca3274c4-0018-430d-9d52-b5d66558fd03"),
                Comment = "Good",
                FoodScore = 1,
                ServingScore = 1
            };

            feedbackDAO.AddFeedback(feedback);

            Assert.That(feedbackDAO.GetFeedbackById(feedback.Id), Is.Not.Null);
        }

        //[Test]
        //public void GetFeedbacksByDate_WhenCalled_ReturnsFeedbacks()
        //{
        //    DateTime START_DATE = new DateTime(2024, 02, 10, 07, 19, 23);
        //    DateTime END_DATE = new DateTime(2024, 02, 10, 08, 49, 50);

        //    var feedbacks = feedbackDAO.GetFeedbacksByDate(START_DATE, END_DATE);

        //    Assert.That(feedbacks, Has.Count.EqualTo(1));
        //}
    }
}
