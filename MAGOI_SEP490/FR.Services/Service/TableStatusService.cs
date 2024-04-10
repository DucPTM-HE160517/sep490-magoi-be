using FR.BusinessObjects.Models;
using FR.DataAccess.DAOimpl;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class TableStatusService : ITableStatusService
    {
        private readonly TableStatusDAO _dao;
        public TableStatusService(TableStatusDAO dao)
        {
            _dao = dao;
        }

        public TableStatus GetTableStatusById(int Id)
        {
            return _dao.GetTableStatusById(Id);
        }

        public List<TableStatus> GetAllTableStatus()
        {
            return _dao.GetAllTableStatus();
        }
    }
}
