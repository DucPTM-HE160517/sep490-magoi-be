using FR.BusinessObjects.Models;
using FR.Common.Ultilities;
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
                CreatedAt = DateTime.Now.ToUniversalTime(),
                TotalAmount = totalAmount
            };

            _dao.AddBill(bill);
            return bill;
        }

        public Bill GetBillById(Guid billId)
        {
            return _dao.GetBillById(billId);
        }

        public List<Bill> GetBillsByDate(DateTime date)
        {
            return _dao.GetBillsByDate(date);
        }

        public void UpdateBill(Bill bill)
        {
            try
            {
                _dao.UpdateBill(bill);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public float GetTotalAmountOfBills(List<Bill> Bills)
        {
            float totalAmount = 0;
            foreach (Bill bill in Bills)
            {
                totalAmount += bill.TotalAmount;
            }
            return totalAmount;
        }

        public int[] GetBillsPerHour(List<Bill> bills)
        {
            int[] billsPerHour = new int[24];
            foreach (var bill in bills)
            {
                int hour = bill.FinishedAt.Value.Hour + 7;

                if (hour > 23)
                {
                    hour -= 24;
                }

                billsPerHour[hour]++;
            }

            return billsPerHour;
        }

        public List<Bill> GetBillsByTimeRange(DateTime startDate, DateTime endDate)
        {
            startDate = Ultilities.AbsoluteStart(startDate);
            endDate = Ultilities.AbsoluteEnd(endDate);

            return _dao.GetBillsByTimeRange(startDate, endDate);
        }
    }
}
