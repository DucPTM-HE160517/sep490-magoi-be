using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public partial class Bill
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillId { get; set; }
        public float TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("BillStatus")]
        public int BillStatusId { get; set; }
    }
}
