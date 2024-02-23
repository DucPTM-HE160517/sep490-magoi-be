using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class BillService : IBillService
    {
        private readonly BillDAO _dao;

        public BillService(BillDAO dao)
        {
            _dao = dao;
        }
        public Bill CreateBill(float totalAmount)
        {
            Bill bill = new Bill
            {
                Id = new Guid(),
                CreatedAt = DateTime.Now,
                TotalAmount = totalAmount
            };

            _dao.AddBill(bill);
            return bill;
        }
        public List<Bill> GetBillsByDate(DateTime date)
        {
            return _dao.GetBillsByDate(date);
        }

        public void UpdateBillFeedback(Guid billId, Guid feedbackId)
        {
            try
            {
                Bill bill = _dao.GetBillById(billId);
                bill.FeedbackId = feedbackId;
                _dao.UpdateBill(bill);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
