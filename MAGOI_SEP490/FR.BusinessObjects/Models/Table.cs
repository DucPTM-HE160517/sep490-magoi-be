using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FR.BusinessObjects.Models
{
    public partial class Table
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(TypeName = "uuid")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Bill")]
        public Guid BillId { get; set; }
        [ForeignKey("TableStatus")]
        public int StatusId { get; set; }
    }
}
