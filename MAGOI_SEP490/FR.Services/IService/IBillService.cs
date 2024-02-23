using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface IBillService
    {
        Bill CreateBill(float totalAmount);
        List<Bill> GetBillsByDate(DateTime date);
    }
}
