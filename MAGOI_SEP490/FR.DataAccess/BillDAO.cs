using FR.BusinessObjects.DataContext;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;

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
        public Bill GetBillById(string billId)
        {
            return _context.Bills.SingleOrDefault(b => b.Id == Guid.Parse(billId));
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
