using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.DAO
{
    public interface ITableStatusDAO : IBaseDAO<TableStatus>
    {
        Task<TableStatus> GetTableStatusById(int id);
    }
}
