using FR.BusinessObjects.DataContext;

namespace FR.DataAccess
{
    public class LabelsDAO
    {
        private readonly DBContext _context;

        public LabelsDAO(DBContext context)
        {
            _context = context;
        }
    }
}
