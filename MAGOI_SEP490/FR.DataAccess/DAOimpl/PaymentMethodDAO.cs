using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;

namespace FR.DataAccess.DAOimpl
{
    public class PaymentMethodDAO : BaseDAO<PaymentMethod>, IPaymentMethodDAO
    {
        public PaymentMethodDAO(DBContext context) : base(context)
        {
        }

        public Task<IPaymentMethodDAO> GetByID(int Id)
        {
            throw new NotImplementedException();
        }

        //public PaymentMethod GetPaymentMethod(int id)
        //{
        //    return _context.PaymentMethods.SingleOrDefault(p => p.Id == id);
        //}
    }
}
