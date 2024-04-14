using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.DAO
{
    public interface IPaymentMethodDAO : IBaseDAO<PaymentMethod>
    {
        Task<PaymentMethod> GetPaymentMethodById(int Id);
    }
}
