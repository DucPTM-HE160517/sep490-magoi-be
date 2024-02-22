using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;
using FR.BusinessObjects.Models.VietQR;

namespace FR.Services.IService
{
    public interface IBankService
    {
        Task<BankingResponse> GetQRAsync(string billId);
    }
}
