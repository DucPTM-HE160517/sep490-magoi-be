using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface IBillService
    {
        Task<Bill> CreateBillAsync(float totalAmount);
        Task<List<Bill>> GetBillsByDateAsync(DateTime date);
        Task<Bill> GetBillByIdAsync(Guid billId);
        Task UpdateBillAsync(Bill bill);
        Task<int[]> GetBillsPerHourAsync(List<Bill> bills);
        Task<List<Bill>> GetBillsByTimeRangeAsync(DateTime startDate, DateTime endDate);
        Task<float> GetTotalAmountOfBillsAsync(List<Bill> bills);
    }
}
