using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface ITableStatusService
    {
        TableStatus GetTableStatusById(int Id);
        IQueryable<TableStatus> GetAllTableStatus();
    }
}
