﻿using FR.BusinessObjects.Models;

namespace FR.Services.IService
{
    public interface IBillService
    {
        Bill CreateBill(float totalAmount);
        List<Bill> GetBillsByDate(DateTime date);
        Bill GetBillById(Guid billId);
        void UpdateBill(Bill bill);
        int[] GetBillsPerHour(List<Bill> bills);
        List<Bill> GetBillsByTimeRange(DateTime startDate, DateTime endDate);
        float GetTotalAmountOfBills(List<Bill> bills);
    }
}
