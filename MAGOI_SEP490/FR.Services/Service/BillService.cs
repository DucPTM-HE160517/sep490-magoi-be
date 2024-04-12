using FR.BusinessObjects.Models;
using FR.Common.Ultilities;
using FR.DataAccess.DAO;
using FR.DataAccess.DAOimpl;
using FR.DataAccess.UOW;
using FR.Services.IService;
using Microsoft.EntityFrameworkCore;
using static HotChocolate.ErrorCodes;

namespace FR.Services.Service
{
    public class BillService : IBillService
    {
        private readonly IBillDAO _dao;
        private readonly IUnitOfWork _uow;

        public BillService(IUnitOfWork uow)
        {
            _uow = uow;
            _dao = ((UnitOfWork)uow).Bill;
        }       

        public async Task<Bill> CreateBillAsync(float totalAmount)
        {
            Bill bill = new Bill
            {
                Id = new Guid(),
                CreatedAt = DateTime.Now.ToUniversalTime(),
                TotalAmount = totalAmount
            };

            _dao.AddAsync(bill);
            await _uow.SaveAsync();
            _uow.Dispose();
            return bill;
        }

        public async Task<List<Bill>> GetBillsByDateAsync(DateTime date)
        {
            return await _dao.GetBillsByDate(date).ToListAsync();
        }

        public async Task<Bill> GetBillByIdAsync(Guid billId)
        {
            return await _dao.GetBillById(billId);
        }

        public async Task UpdateBillAsync(Bill bill)
        {
            try
            {
                _dao.Update(bill);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<int[]> GetBillsPerHourAsync(List<Bill> bills)
        {
            int[] billsPerHour = new int[24];
            foreach (var bill in bills)
            {
                int hour = bill.FinishedAt.Value.Hour;

                billsPerHour[hour]++;
            }

            return billsPerHour;
        }

        public async Task<List<Bill>> GetBillsByTimeRangeAsync(DateTime startDate, DateTime endDate)
        {
            startDate = Ultilities.AbsoluteStart(startDate);
            endDate = Ultilities.AbsoluteEnd(endDate);

            return await _dao.GetBillsByTimeRange(startDate, endDate).ToListAsync();
        }

        public async Task<float> GetTotalAmountOfBillsAsync(List<Bill> bills)
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
