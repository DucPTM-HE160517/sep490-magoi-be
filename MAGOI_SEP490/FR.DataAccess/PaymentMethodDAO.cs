﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.DataAccess
{
    public class PaymentMethodDAO
    {
        private readonly DBContext _context;
        public PaymentMethodDAO(DBContext context)
        {
            _context = context;
        }

        public PaymentMethod GetPaymentMethod(int id)
        {
            return _context.PaymentMethods.SingleOrDefault(p => p.Id == id);
        }
    }
}
