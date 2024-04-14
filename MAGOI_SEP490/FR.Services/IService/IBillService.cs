﻿using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface IBillService
    {
        Task<Bill> CreateBill(float totalAmount);
        IQueryable<Bill> GetBillsByDate(DateTime date);
        Task<Bill> GetBillById(Guid billId);
        int[] GetBillsPerHour(List<Bill> bills);
        IQueryable<Bill> GetBillsByTimeRange(DateTime startDate, DateTime endDate);
        float GetTotalAmountOfBills(List<Bill> bills);
    }
}
