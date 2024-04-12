using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR.DataAccess.DAO
{
    public interface IPaymentMethodDAO : IBaseDAO<PaymentMethod>
    {
        Task<PaymentMethod> GetPaymentMethodById(int Id);
    }
}
