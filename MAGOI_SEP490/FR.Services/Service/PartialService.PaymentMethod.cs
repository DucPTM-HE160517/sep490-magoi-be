using FR.BusinessObjects.Models;
using FR.DataAccess.UOW;
using FR.Services.IService;

namespace FR.Services.Service
{
    public partial class Service : IPaymentMethodService
    {
        public async Task<PaymentMethod> GetPaymentMethodById(int id)
        {
            return await _uow.PaymentMethodDAO.GetPaymentMethodById(id);
        }
    }
}
