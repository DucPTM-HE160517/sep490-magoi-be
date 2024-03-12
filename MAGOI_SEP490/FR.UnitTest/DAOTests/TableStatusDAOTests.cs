using FR.BusinessObjects.Models;
using FR.UnitTest;

namespace FR.UnitTests.DAOTests
{
    public class TableStatusDAOTests : BaseTest
    {
        public TableStatusDAOTests() : base()
        {

        }

        [OneTimeTearDown]
        public void Clean()
        {
            context.Database.EnsureDeleted();
        }

        [Test]
        public void GetTableStatusById_WhenCalled_ReturnsTableStatus()
        {
            const int TABLE_STATUS_ID = (int)TableStatusId.Available;

            var tableStatus = tableStatusDAO.GetTableStatusById(TABLE_STATUS_ID);

            Assert.That(tableStatus.Id, Is.EqualTo(TABLE_STATUS_ID));
            Assert.That(tableStatus, Is.Not.Null);
        }

        [Test]
        public void GetAllTableStatus_WhenCalled_ReturnsAllTableStatus()
        {
            var tableStatuses = tableStatusDAO.GetAllTableStatus();

            Assert.That(tableStatuses.Count, Is.EqualTo(3));
        }
    }
}
