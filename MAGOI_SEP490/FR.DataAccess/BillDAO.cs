using FR.BusinessObjects.DataContext;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            List<Bill> list = new List<Bill>();
            string formattedDate = date.ToString("yyyy/MM/dd");
            foreach (Bill bill in _context.Bills.ToList())
            {
                string createdDate = bill.CreatedAt.ToString("yyyy/MM/dd");
                list.Add(bill);
            }
            return list;
        }
    }
}
