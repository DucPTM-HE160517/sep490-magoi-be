using FR.BusinessObjects.DataContext;

namespace FR.DataAccess.DAOimpl
{
    public class FoodLabelsDAO
    {
        private readonly DBContext _context;

        public FoodLabelsDAO(DBContext context)
        {
            _context = context;
        }
    }
}
