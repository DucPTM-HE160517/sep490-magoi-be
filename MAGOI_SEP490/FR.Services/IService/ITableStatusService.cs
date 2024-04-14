using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface ITableStatusService
    {
        Task<TableStatus> GetTableStatusById(int Id);
        Task<IEnumerable<TableStatus>> GetAllTableStatus();
    }
}
