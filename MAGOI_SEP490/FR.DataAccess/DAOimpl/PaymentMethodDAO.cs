using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.DataAccess.DAOimpl
{
    public class PaymentMethodDAO
    {
        private readonly DBContext _context;
        public PaymentMethodDAO(DBContext context)
        {
            _context = context;
        }

        public PaymentMethod GetPaymentMethod(int id)
        {
            return _context.PaymentMethods.SingleOrDefault(p => p.Id == id);
        }
    }
}
