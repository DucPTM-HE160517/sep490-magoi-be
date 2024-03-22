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

        //[Test]
        //public void AddFeedback_WhenCalled_AddsFeedback()
        //{
        //    var feedback = new Feedback
        //    {
        //        Id = Guid.Parse("f120a375-b3d9-42c7-a633-28a38e9912db"),
        //        BillId = Guid.Parse("ca3274c4-0018-430d-9d52-b5d66558fd03"),
        //        Comment = "Good",
        //        FoodScore = 1,
        //        ServingScore = 1
        //    };

        //    feedbackDAO.AddFeedback(feedback);

        //    Assert.That(feedbackDAO.GetFeedbackById(feedback.Id), Is.Not.Null);
        //}
    }
}
