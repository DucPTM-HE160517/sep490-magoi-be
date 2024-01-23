using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FR.BusinessObjects.Models
{
    public partial class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Table")]
        public int TableId { get; set; }
        [ForeignKey("Bill")]
        public int BillId { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("Feedback")]
        public int FeedbackId { get; set; }
        [ForeignKey("OrderStatus")]
        public int OrderStatusId { get; set; }
    }
}
