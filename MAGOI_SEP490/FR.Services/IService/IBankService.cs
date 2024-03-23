using FR.BusinessObjects.Models.VietQR;

namespace FR.Services.IService
{
    public interface IBankService
    {
        Task<BankingResponse> GetQRAsync(string tableName, float totalAmount);
    }
}
