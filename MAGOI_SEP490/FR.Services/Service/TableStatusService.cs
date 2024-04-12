using FR.BusinessObjects.Models;
using FR.DataAccess.DAO;
using FR.DataAccess.DAOimpl;
using FR.DataAccess.UOW;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class TableStatusService : ITableStatusService
    {
        private readonly ITableStatusDAO _dao;
        private readonly IUnitOfWork _uow;
        public TableStatusService(IUnitOfWork uow)
        {
            _uow = uow;
            _dao = ((UnitOfWork)uow).TableStatus;
        }
        public async Task<TableStatus> GetTableStatusByIdAsync(int Id)
        {
            return await _dao.GetTableStatusById(Id);
        }

        public async Task<List<TableStatus>> GetAllTableStatusAsync()
        {
            return (List<TableStatus>)await _dao.GetAllAsync();
        }
    }
}
