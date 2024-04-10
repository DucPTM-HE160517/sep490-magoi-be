using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.DataAccess.DAOimpl
{
    public class TableStatusDAO
    {
        private readonly DBContext _context;
        public TableStatusDAO(DBContext context)
        {
            _context = context;
        }
        public TableStatus GetTableStatusById(int id)
        {
            return _context.TableStatus.SingleOrDefault(s => s.Id == id);
        }
        public List<TableStatus> GetAllTableStatus()
        {
            return _context.TableStatus.ToList();
        }
    }
}
