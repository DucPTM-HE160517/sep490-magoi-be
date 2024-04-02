using FR.BusinessObjects.Models;
using FR.Infrastructure.Enums;
using FR.UnitTest;

namespace FR.UnitTests.DAOTests
{
    public class OrderDAOTests : BaseTest
    {
        public OrderDAOTests() : base()
        {

        }

        [OneTimeTearDown]
        public void Clean()
        {
            context.Database.EnsureDeleted();
        }

        [Test]
        public void GetOrderById_WhenCalled_ReturnsOrder()
        {
            Guid ORDER_ID = Guid.Parse("11238123-7115-4294-af3a-149a0cd21dba");

            var order = orderDAO.GetOrderById(ORDER_ID);
            Assert.IsNotNull(order);
        }

        [Test]
        public void AddOrder_WhenCalled_AddsOrder()
        {
            var order = new Order
            {
                Id = Guid.Parse("16eb85ce-402a-439f-824c-df7bcaf36931"),
                TableId = Guid.Parse("9e4761a1-22d2-4a1e-a0da-e9224d75f6bb"),
                CreatedAt = new DateTime(2024, 01, 01, 00, 00, 00),
                BillId = Guid.Parse("ca3274c4-0018-430d-9d52-b5d66558fd03"),
                OrderStatusId = (int)OrderStatusId.Pending
            };

            orderDAO.AddOrder(order);
            var result = orderDAO.GetOrderById(order.Id);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void UpdateOrder_WhenCalled_UpdatesOrder()
        {
            Guid ORDER_ID = Guid.Parse("67074714-1dd9-4f57-806e-0e561a8940a2");
            var orderToUpdate = orderDAO.GetOrderById(ORDER_ID);

            Guid TABLE_ID = Guid.Parse("24421c43-7ce9-49f9-b279-545130db8777");
            Guid BILL_ID = Guid.Parse("022a14ef-f5a5-416d-a8b3-68b20133d897");
            DateTime CREATE_AT = new DateTime(2024, 01, 01, 00, 00, 01);
            const int ORDER_STATUS_ID = (int)OrderStatusId.Cooking;

            orderToUpdate.TableId = TABLE_ID;
            orderToUpdate.CreatedAt = CREATE_AT;
            orderToUpdate.BillId = BILL_ID;
            orderToUpdate.OrderStatusId = ORDER_STATUS_ID;

            orderDAO.UpdateOrder(orderToUpdate);
            var result = orderDAO.GetOrderById(ORDER_ID);

            Assert.That(result.TableId, Is.EqualTo(TABLE_ID));
            Assert.That(result.CreatedAt, Is.EqualTo(CREATE_AT));
            Assert.That(result.BillId, Is.EqualTo(BILL_ID));
            Assert.That(result.OrderStatusId, Is.EqualTo(ORDER_STATUS_ID));
        }

        [Test]
        public void DeleteOrder_WhenCalled_DeletesOrder()
        {
            var order = new Order
            {
                TableId = Guid.Parse("9e4761a1-22d2-4a1e-a0da-e9224d75f6bb"),
                CreatedAt = new DateTime(2024, 01, 01, 00, 00, 00),
                BillId = Guid.Parse("ca3274c4-0018-430d-9d52-b5d66558fd03"),
                OrderStatusId = (int)OrderStatusId.Finished
            };

            orderDAO.AddOrder(order);

            Assert.That(order, Is.Not.Null);

            orderDAO.DeleteOrder(order);
            var result = orderDAO.GetOrderById(order.Id);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void GetOrdersByStatusId_WhenCalled_ReturnsOrders()
        {
            int ORDER_STATUS_ID = (int)OrderStatusId.Serving;

            var orders = orderDAO.GetOrdersByStatusId(ORDER_STATUS_ID);
            Assert.That(orders, Has.Count.EqualTo(1));
        }

        [Test]
        public void GetOrdersByTableId_WhenCalled_ReturnsOrders()
        {
            Guid TABLE_ID = Guid.Parse("9e4761a1-22d2-4a1e-a0da-e9224d75f6bb");

            var orders = orderDAO.GetOrdersByTableId(TABLE_ID);
            Assert.That(orders, Has.Count.EqualTo(3));
        }

        [Test]
        public void GetOrdersByTableIdAndOrderStatusId_WhenCalled_ReturnsOrders()
        {
            Guid TABLE_ID = Guid.Parse("9e4761a1-22d2-4a1e-a0da-e9224d75f6bb");
            const int ORDER_STATUS_ID = (int)OrderStatusId.Serving;

            var orders = orderDAO.GetOrdersByTableIdAndOrderStatusId(TABLE_ID, ORDER_STATUS_ID);
            Assert.That(orders, Has.Count.EqualTo(1));
        }

        [Test]
        public void GetTotalAmountOfOrder_WhenCalled_ReturnsTotalPrice()
        {
            Guid ORDER_ID = Guid.Parse("11238123-7115-4294-af3a-149a0cd21dba");

            var totalAmount = orderDAO.GetTotalAmmountOfOrder(ORDER_ID);

            Assert.That(totalAmount, Is.EqualTo(199000));
        }

        [Test]
        public void GetOrdersByBillId_WhenCalled_ReturnsOrders()
        {
            Guid BILL_ID = Guid.Parse("ca3274c4-0018-430d-9d52-b5d66558fd03");

            var orders = orderDAO.GetOrdersByBillId(BILL_ID);
            Assert.That(orders, Has.Count.EqualTo(3));
        }

        [Test]
        public void GetServedOrdersByTableId_WhenCalled_ReturnsServedOrders()
        {
            Guid TABLE_ID = Guid.Parse("24421c43-7ce9-49f9-b279-545130db8777");

            var orders = orderDAO.GetServedOrdersByTableId(TABLE_ID);
            Assert.That(orders, Has.Count.EqualTo(1));
        }

        [Test]
        public void GetServingOrdersByTimeRange_WhenCalled_ReturnsServingOrders()
        {
            DateTime START_DATE = new DateTime(2024, 02, 10, 00, 00, 00);
            DateTime END_DATE = new DateTime(2024, 02, 10, 23, 59, 59);

            var orders = orderDAO.GetServingOrdersByTimeRange(START_DATE, END_DATE).ToList();
            Assert.That(orders, Has.Count.EqualTo(1));
        }

        [Test]
        public void GetServedOrdersByTimeRange_WhenCalled_ReturnsServedOrders()
        {
            DateTime START_DATE = new DateTime(2024, 12, 02, 00, 00, 00);
            DateTime END_DATE = new DateTime(2024, 12, 02, 23, 59, 59);

            var orders = orderDAO.GetServedOrdersByTimeRange(START_DATE, END_DATE).ToList();
            Assert.That(orders, Has.Count.EqualTo(1));
        }

        [Test]
        public void GetOrdersByTimeRange_WhenCalled_ReturnsOrders()
        {
            DateTime START_DATE = new DateTime(2024, 12, 02, 00, 00, 00);
            DateTime END_DATE = new DateTime(2024, 12, 02, 23, 59, 59);

            var orders = orderDAO.GetOrdersByTimeRange(START_DATE, END_DATE).ToList();
            Assert.That(orders, Has.Count.EqualTo(3));
        }
    }
}

