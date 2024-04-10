using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.DataAccess.DAOimpl
{
    public class LabelsDAO
    {
        private readonly DBContext _context;

        public LabelsDAO(DBContext context)
        {
            _context = context;
        }
        public Labels GetLabelsById(int id)
        {
            return _context.Labels.SingleOrDefault(x => x.Id == id);
        }
    }
}
