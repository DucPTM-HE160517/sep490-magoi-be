using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess.DAOimpl
{
    public class LabelsDAO : BaseDAO<Labels>, ILabelsDAO
    {
        //public Labels GetLabelsById(int id)
        //{
        //    return _context.Labels.SingleOrDefault(x => x.Id == id);
        //}
        public LabelsDAO(DBContext context) : base(context)
        {
        }

        public Task<Labels> GetLabelsById(int id)
        {
            return _context.Labels.SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
