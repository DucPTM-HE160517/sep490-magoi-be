using FR.BusinessObjects.DataContext;

namespace FR.DataAccess
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
