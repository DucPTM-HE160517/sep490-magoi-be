using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FR.BusinessObjects.Models
{
    public partial class Order : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(TypeName = "uuid")]
        public Guid Id { get; set; }
        [ForeignKey("Table")]
        public Guid TableId { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("Bill")]
        public Guid BillId { get; set; }
        [ForeignKey("OrderStatus")]
        public int OrderStatusId { get; set; }
    }
}
