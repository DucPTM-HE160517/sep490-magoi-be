using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.DAO
{
    public interface ITableDAO : IBaseDAO<Table>
    {
        Task<bool> IsExist(string name);
        Task<Table> GetTableById(Guid id);
        Task<Table> GetTableByName(string name);
        IQueryable<Table> GetTablesByStatusId(int tableStatusId);
    }
}
