using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.DataAccess
{
    public class BillDAO
    {
        private readonly DBContext _context;
        public BillDAO(DBContext context)
        {
            _context = context;
        }
        public void AddBill(Bill bill)
        {
            _context.Add(bill);
            _context.SaveChanges();
        }
    }
}
