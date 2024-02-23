﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FR.BusinessObjects.Models
{
    public partial class Bill
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(TypeName = "uuid")]
        public Guid Id { get; set; }
        [ForeignKey("PaymentStatus")]
        public int PaymentStatusId { get; set; }
        public float TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("Feedback")]
        public Guid FeedbackId { get; set; }
    }
}
