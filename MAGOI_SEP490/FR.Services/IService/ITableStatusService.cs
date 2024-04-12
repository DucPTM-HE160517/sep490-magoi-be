using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface ITableStatusService
    {
        Task<TableStatus> GetTableStatusByIdAsync(int Id);
        Task<List<TableStatus>> GetAllTableStatusAsync();
    }
}
