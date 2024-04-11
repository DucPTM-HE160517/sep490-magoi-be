using FR.BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR.DataAccess.DAO
{
    public interface IPaymentMethodDAO
    {
        Task<PaymentMethod> GetPaymentMethodById(int Id);
    }
}
