using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.IDAO;

namespace FR.DataAccess
{
    public class LabelsDAO : BaseDAO<Labels>, ILabelsDAO
    {
        public LabelsDAO(DBContext context) : base(context)
        {
        }
    }
}
