using FR.BusinessObjects.Models;
using FR.DataAccess.DAO;
using FR.DataAccess.DAOimpl;
using FR.DataAccess.UOW;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class PaymentMethodService : IPaymentMethodService
    {
        private readonly IPaymentMethodDAO _dao;
        private readonly IUnitOfWork _uow;
        public PaymentMethodService(IUnitOfWork uow)
        {
            _uow = uow;
            _dao = ((UnitOfWork)uow).PaymentMethod;
        }

        public async Task<PaymentMethod> GetPaymentMethodById(int id)
        {
            return await _dao.GetPaymentMethodById(id);
        }
    }
}
