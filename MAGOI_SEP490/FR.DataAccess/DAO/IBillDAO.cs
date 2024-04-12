using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.DAO
{
    public interface IBillDAO : IBaseDAO<Bill>
    {
        Task<Bill> GetBillById(Guid id);
        IQueryable<Bill> GetBillsByDate(DateTime date);
        IQueryable<Bill> GetBillsByTimeRange(DateTime startDate, DateTime endDate);
    }
}
