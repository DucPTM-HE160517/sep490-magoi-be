using FR.BusinessObjects.Models;
using FR.UnitTest;

namespace FR.UnitTests.DAOTests
{
    public class TableDAOTests : BaseTest
    {
        public TableDAOTests() : base()
        {

        }

        [OneTimeTearDown]
        public void Clean()
        {
            context.Database.EnsureDeleted();
        }

        [Test]
        public void GetTables_WhenCalled_ReturnsAllTable()
        {
            var tables = tableDAO.GetTables();

            Assert.That(tables, Has.Count.EqualTo(3));
        }

        [Test]
        public void GetTablesByStatusId_WhenCalled_ReturnsTables()
        {
            const int TBALE_STATUS_ID = (int)TableStatusId.Available;

            var tables = tableDAO.GetTablesByStatusId(TBALE_STATUS_ID);

            Assert.That(tables, Has.Count.EqualTo(1));
        }

        [Test]
        public void GetTableById_WhenCalled_ReturnsTable()
        {
            Guid TABLE_ID = Guid.Parse("9e4761a1-22d2-4a1e-a0da-e9224d75f6bb");

            var table = tableDAO.GetTable(TABLE_ID);

            Assert.That(table, Is.Not.Null);
        }

        [Test]
        public void GetTableByName_WhenCalled_ReturnsTable()
        {
            const string TABLE_NAME = "Bàn 1";

            var table = tableDAO.GetTableByName(TABLE_NAME);

            Assert.That(table, Is.Not.Null);
        }

        [Test]
        public void UpdateTableStatus_WhenCalled_UpdatesTableStatus()
        {
            Guid TABLE_ID = Guid.Parse("9e4761a1-22d2-4a1e-a0da-e9224d75f6bb");
            const int TABLE_STATUS_ID = (int)TableStatusId.Available;

            tableDAO.UpdateTableStatus(TABLE_ID, (TableStatusId)TABLE_STATUS_ID);
            var table = tableDAO.GetTable(TABLE_ID);

            Assert.That(table.StatusId, Is.EqualTo(TABLE_STATUS_ID));
        }

        [Test]
        public void GetTableByBillId_WhenCalled_ReturnsTable()
        {
            Guid BILL_ID = Guid.Parse("ca3274c4-0018-430d-9d52-b5d66558fd03");

            var table = tableDAO.GetTableByBillId(BILL_ID);

            Assert.That(table, Is.Not.Null);
        }
    }
}
