using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR.BusinessObjects.Models
{
    public enum PaymentStatusId : int
    {
        Unpaid = 1,
        Paid = 2
    }
    public class PaymentStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
