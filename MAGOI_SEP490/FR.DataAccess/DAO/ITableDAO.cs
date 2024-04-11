using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;

namespace FR.DataAccess.DAO
{
    public interface ITableDAO
    {
        Task<bool> IsExist(string name);
        Task<Table> GetTable(Guid id);
        Task<Table> GetTable(string name);
        IQueryable<Table> GetTables(int tableStatusId);
    }
}
