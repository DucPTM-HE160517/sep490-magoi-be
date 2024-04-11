using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess.DAOimpl
{
    public class TableStatusDAO : BaseDAO<TableStatus>, ITableStatusDAO
    {
        public TableStatusDAO(DBContext context) : base(context)
        {
        }
        public async Task<TableStatus> GetTableStatusById(int id)
        {
            return await _context.TableStatus.SingleOrDefaultAsync(s => s.Id == id);
        }
    }
}
