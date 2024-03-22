using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface IPaymentMethodService
    {
        PaymentMethod GetPaymentMethodById(int id);
    }
}
