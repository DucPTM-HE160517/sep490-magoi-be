using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class PaymentMethodService : IPaymentMethodService
    {
        private readonly PaymentMethodDAO _dao;
        public PaymentMethodService(PaymentMethodDAO dao)
        {
            _dao = dao;
        }
        public PaymentMethod GetPaymentMethodById(int id)
        {
            return _dao.GetPaymentMethod(id);
        }
    }
}
