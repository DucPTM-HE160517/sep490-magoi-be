using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.Services.IService
{
    public interface IPaymentMethodService
    {
        Task<PaymentMethod> GetPaymentMethodById(int id);
    }
}
