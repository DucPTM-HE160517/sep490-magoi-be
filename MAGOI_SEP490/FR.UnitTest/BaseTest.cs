using FR.BusinessObjects.DataContext;
using FR.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace FR.UnitTest
{
    public class BaseTest
    {
        protected BillDAO billDAO;
        protected FeedbackDAO feedbackDAO;
        protected FoodCategoryDAO foodCategoryDAO;
        protected FoodDAO foodDAO;
        protected FoodOrderDAO foodOrderDAO;
        protected LabelsDAO labelsDAO;
        protected OrderDAO orderDAO;
        protected FoodLabelsDAO foodLabelsDAO;
        protected OrderStatusDAO orderStatusDAO;
        protected PaymentMethodDAO paymentMethodDAO;
        protected TableDAO tableDAO;
        protected TableStatusDAO tableStatusDAO;

        protected DBContext context;

        public BaseTest()
        {
            DbContextOptions<DBContext> options = new DbContextOptionsBuilder<DBContext>()
                .UseInMemoryDatabase(databaseName: "TestDB")
                .Options;

            context = new DBContext(options);
            context.Seed();

            billDAO = new BillDAO(context);
            feedbackDAO = new FeedbackDAO(context);
            foodCategoryDAO = new FoodCategoryDAO(context);
            foodDAO = new FoodDAO(context);
            foodOrderDAO = new FoodOrderDAO(context);
            labelsDAO = new LabelsDAO(context);
            orderDAO = new OrderDAO(context);
            foodLabelsDAO = new FoodLabelsDAO(context);
            tableDAO = new TableDAO(context);
            tableStatusDAO = new TableStatusDAO(context);
            orderStatusDAO = new OrderStatusDAO(context);
            paymentMethodDAO = new PaymentMethodDAO(context);
        }
    }
}
