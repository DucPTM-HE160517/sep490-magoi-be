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
    }
}
