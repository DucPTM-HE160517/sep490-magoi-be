using FR.BusinessObjects.Models;
using FR.UnitTest;

namespace FR.UnitTests.DAOTests
{
    public class PaymentMethodDAOTests : BaseTest
    {
        public PaymentMethodDAOTests() : base() { }

        [OneTimeTearDown]
        public void Clean()
        {
            context.Database.EnsureDeleted();
        }

        [Test]
        public void GetPaymentMethod_WhenCalled_ReturnsPaymentMethod()
        {
            const int PAYMENT_METHOD_ID = (int)PaymentMethodId.Cash;

            var result = paymentMethodDAO.GetPaymentMethod(PAYMENT_METHOD_ID);

            Assert.That(result, Is.Not.Null);
        }
    }
}
