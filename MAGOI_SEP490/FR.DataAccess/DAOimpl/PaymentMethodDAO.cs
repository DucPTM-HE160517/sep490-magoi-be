using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess.DAOimpl
{
    public class PaymentMethodDAO : BaseDAO<PaymentMethod>, IPaymentMethodDAO
    {
        public PaymentMethodDAO(DBContext context) : base(context)
        {
        }

        public async Task<PaymentMethod> GetPaymentMethodById(int Id)
        {
            return await _context.PaymentMethods.FindAsync(Id);
        }

        //public PaymentMethod GetPaymentMethod(int id)
        //{
        //    return _context.PaymentMethods.SingleOrDefault(p => p.Id == id);
        //}
    }
}
