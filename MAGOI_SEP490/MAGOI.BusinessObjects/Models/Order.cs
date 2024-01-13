using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace demo.Models
{
    public partial class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("Table")]
        public int TableID { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        [ForeignKey("OrderStatus")]
        public int OrderStatusId { get; set; }
        [ForeignKey("Bill")]
        public int BillId { get; set; }
    }
}
