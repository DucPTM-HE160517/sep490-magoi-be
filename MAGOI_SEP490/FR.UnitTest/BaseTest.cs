using FR.BusinessObjects.DataContext;
using FR.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace FR.UnitTest
{
    public class BaseTest
    {
        protected FoodDAO foodDAO;

        protected DBContext context;
        public BaseTest()
        {
            DbContextOptions<DBContext> options = new DbContextOptionsBuilder<DBContext>()
                .UseInMemoryDatabase(databaseName: "TestDB")
                .Options;

            context = new DBContext(options);
            context.Seed();

            foodDAO = new FoodDAO(context);
        }
    }
}
