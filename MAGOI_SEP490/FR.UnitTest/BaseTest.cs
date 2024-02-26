using FR.BusinessObjects.DataContext;
using FR.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace FR.UnitTest
{
    public class BaseTest
    {
        protected DBContext context;
        protected FoodDAO foodDAO;

        public BaseTest()
        {
            DbContextOptions<DBContext> options = new DbContextOptionsBuilder<DBContext>()
                .UseInMemoryDatabase(databaseName: "FR_Db_Test")
                .Options;

            context = new DBContext(options);
            context.SeedTestData();

            foodDAO = new FoodDAO(context);
        }
    }
}
