using FR.BusinessObjects.DataContext;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.DataContext;
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

        public Bill GetBillById(string billId)
        {
            return _context.Bills.SingleOrDefault(b => b.Id == Guid.Parse(billId));
        }
    }
}
