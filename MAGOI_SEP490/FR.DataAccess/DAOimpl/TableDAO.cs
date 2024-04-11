using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;
using FR.Infrastructure.Enums;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess.DAOimpl
{
    public class TableDAO : BaseDAO<Table>, ITableDAO
    {
        public TableDAO(DBContext context) : base(context)
        {
        }
        public async Task<Table> GetTableById(Guid id)
        {
            return await _context.Tables.FindAsync(id);
        }

        public async Task<Table> GetTableByName(string name)
        {
            return await _context.Tables.SingleOrDefaultAsync(table => table.Name.Equals(name));
        }

        public IQueryable<Table> GetTablesByStatusId(int tableStatusId)
        {
            return _context.Tables.Where(t => t.StatusId == tableStatusId);
        }

        public async Task<bool> IsExist(string name)
        {
            return await _context.Tables.AnyAsync(t => t.Name == name);
        }
    }
}
