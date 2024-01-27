using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;
using FR.DataAccess;
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
    }
}
