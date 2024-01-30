using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class TableService : ITableService
    {
        private readonly TableDAO _dao;
        public TableService(TableDAO dao)
        {
            _dao = dao;
        }

        public List<Table> GetTables()
        {
            return _dao.GetTables();
        }

        public Table GetTable(int id) {
            return _dao.GetTable(id);
	    }

        public void UpdateTableStatus(int tableId, TableStatusId statusId) {
            _dao.UpdateTableStatus(tableId, statusId);
	    }
    }
}
