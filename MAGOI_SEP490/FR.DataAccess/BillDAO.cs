﻿using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace FR.DataAccess
{
    public class BillDAO
    {
        private readonly DBContext _context;
        public BillDAO(DBContext context)
        {
            _context = context;
        }
        public void AddBill(Bill bill)
        {
            _context.Add(bill);
            _context.SaveChanges();
        }

        public void UpdateBill(Bill bill)
        {
            _context.Entry(bill).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Bill GetBillById(Guid billId)
        {
            return _context.Bills.SingleOrDefault(b => b.Id == billId);
        }

        public List<Bill> GetBillsByDate(DateTime date)
        {
            return _context.Bills.Where(b => b.CreatedAt.Date == date.Date).ToList();
        }
    }
}
