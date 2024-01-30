using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.DataAccess
{
    public class TableDAO
    {
        private readonly DBContext _context;
        public TableDAO(DBContext context)
        {
            _context = context;
        }

        public List<Table> GetTables()
        {
            return _context.Tables.ToList();
        }

        public Table GetTable(int id) {
            return _context.Tables.FirstOrDefault(table => table.Id.Equals(id));
	    }

        public void UpdateTableStatus(int tableId, TableStatusId statusId) {
            Table table = GetTable(tableId);
            table.StatusId = (int)statusId;
            _context.SaveChanges();
	    }
    }
}
