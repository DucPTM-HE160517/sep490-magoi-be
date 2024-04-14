using FR.BusinessObjects.Models;
using FR.DataAccess.DAO;
using FR.DataAccess.DAOimpl;
using FR.DataAccess.UOW;
using FR.Services.IService;

namespace FR.Services.Service
{
    public partial class Service : ITableStatusService
    {
        public async Task<TableStatus> GetTableStatusById(int Id)
        {
            return await _uow.TableStatusDAO.GetTableStatusById(Id);
        }

        public async Task<IEnumerable<TableStatus>> GetAllTableStatus()
        {
            return await _uow.TableStatusDAO.GetAllAsync();
        }
    }
}
