using FR.BusinessObjects.Models;
using FR.Common.Ultilities;
using FR.DataAccess.UOW;
using FR.Services.IService;

namespace FR.Services.Service
{
    public partial class Service : IBillService
    {
        private readonly IUnitOfWork _uow;
        public Service(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<Bill> CreateBill(float totalAmount)
        {
            Bill bill = new Bill
            {
                Id = new Guid(),
                CreatedAt = DateTime.Now.ToUniversalTime(),
                TotalAmount = totalAmount
            };

            await _uow.BillDAO.AddAsync(bill);
            await _uow.SaveAsync();
            _uow.Dispose();
            return bill;
        }

        public IQueryable<Bill> GetBillsByDate(DateTime date)
        {
            return _uow.BillDAO.GetBillsByDate(date);
        }

        public async Task<Bill> GetBillById(Guid billId)
        {
            return await _uow.BillDAO.GetBillById(billId);
        }

        public int[] GetBillsPerHour(List<Bill> bills)
        {
            int[] billsPerHour = new int[24];
            foreach (var bill in bills)
            {
                int hour = bill.FinishedAt.Value.Hour;

                billsPerHour[hour]++;
            }

            return billsPerHour;
        }

        public IQueryable<Bill> GetBillsByTimeRange(DateTime startDate, DateTime endDate)
        {
            startDate = Ultilities.AbsoluteStart(startDate);
            endDate = Ultilities.AbsoluteEnd(endDate);

            return _uow.BillDAO.GetBillsByTimeRange(startDate, endDate);
        }

        public float GetTotalAmountOfBills(List<Bill> bills)
        {
            float totalAmount = 0;
            foreach (Bill bill in bills)
            {
                totalAmount += bill.TotalAmount;
            }
            return totalAmount;
        }
    }
}
