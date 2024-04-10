using FR.BusinessObjects.DataContext;

namespace FR.DataAccess.DAOimpl
{
    public class OrderStatusDAO
    {
        private readonly DBContext _context;

        public OrderStatusDAO(DBContext context)
        {
            _context = context;
        }
    }
}
