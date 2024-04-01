using FR.BusinessObjects.Models;
using FR.Infrastructure.Enums;
using FR.UnitTest;

namespace FR.UnitTests.DAOTests
{
    public class BillDAOTests : BaseTest
    {
        public BillDAOTests() : base()
        {

        }

        [OneTimeTearDown]
        public void Clean()
        {
            context.Database.EnsureDeleted();
        }

        [Test]
        public void AddBill_WhenCalled_AddsBill()
        {
            var bill = new Bill
            {
                TotalAmount = 1,
                CreatedAt = new DateTime(2024, 01, 01, 0, 0, 0),
                FinishedAt = new DateTime(2024, 01, 01, 1, 0, 0),
                PaymentMethodId = 1
            };

            billDAO.AddBill(bill);
            var result = billDAO.GetBillById(bill.Id);

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void UpdateBill_WhenCalled_UpdatesBill()
        {
            Guid BILL_ID = Guid.Parse("ca3274c4-0018-430d-9d52-b5d66558fd03");
            var billToUpdate = billDAO.GetBillById(BILL_ID);

            const float NEW_TOTAL_AMOUNT = 2000000;
            DateTime NEW_CREATED_AT = new DateTime(2024, 01, 01, 0, 0, 1);
            DateTime NEW_FINISHED_AT = new DateTime(2024, 01, 01, 1, 0, 1);
            const int NEW_PAYMENT_METHOD_ID = (int)PaymentMethodId.Banking;

            billToUpdate.TotalAmount = NEW_TOTAL_AMOUNT;
            billToUpdate.CreatedAt = NEW_CREATED_AT;
            billToUpdate.FinishedAt = NEW_FINISHED_AT;
            billToUpdate.PaymentMethodId = NEW_PAYMENT_METHOD_ID;

            billDAO.UpdateBill(billToUpdate);
            var result = billDAO.GetBillById(billToUpdate.Id);

            Assert.That(result.TotalAmount, Is.EqualTo(NEW_TOTAL_AMOUNT));
            Assert.That(result.CreatedAt, Is.EqualTo(NEW_CREATED_AT));
            Assert.That(result.FinishedAt, Is.EqualTo(NEW_FINISHED_AT));
            Assert.That(result.PaymentMethodId, Is.EqualTo(NEW_PAYMENT_METHOD_ID));
        }

        [Test]
        public void GetBillById_WhenCalled_ReturnsBill()
        {
            Guid BILL_ID = Guid.Parse("ca3274c4-0018-430d-9d52-b5d66558fd03");
            var result = billDAO.GetBillById(BILL_ID);

            Assert.That(result.Id, Is.EqualTo(BILL_ID));
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void GetBillsByDate_WhenCalled_ReturnsBills()
        {
            DateTime DATE_TIME = new DateTime(2024, 01, 01);
            var result = billDAO.GetBillsByDate(DATE_TIME);

            Assert.That(result, Has.Count.EqualTo(1));
        }

        [Test]
        public void GetBillsByTimeRange_WhenCalled_ReturnsBills()
        {
            DateTime START_DATE = new DateTime(2024, 12, 01, 0, 0, 0);
            DateTime END_DATE = new DateTime(2024, 12, 03, 1, 0, 0);
            var result = billDAO.GetBillsByTimeRange(START_DATE, END_DATE);

            Assert.That(result, Has.Count.EqualTo(2));
        }
    }
}
