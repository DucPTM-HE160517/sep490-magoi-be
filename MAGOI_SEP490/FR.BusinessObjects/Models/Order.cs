﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FR.BusinessObjects.Models
{
    public partial class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(TypeName = "uuid")]
        public Guid Id { get; set; }
        [ForeignKey("Table")]
        public Guid TableId { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("Bill")]
        public Guid BillId { get; set; }
        [ForeignKey("Feedback")]
        public Guid FeedbackId { get; set; }
        [ForeignKey("OrderStatus")]
        public int OrderStatusId { get; set; }
    }
}
