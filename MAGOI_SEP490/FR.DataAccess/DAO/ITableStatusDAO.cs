using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.DAO
{
    public interface ITableStatusDAO : IBaseDAO<TableStatus>
    {
        Task<TableStatus> GetTableStatusById(int id);
    }
}
