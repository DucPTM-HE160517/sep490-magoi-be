using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FR.BusinessObjects.Models
{
    public partial class Feedback
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(TypeName = "uuid")]
        public Guid Id { get; set; }
        public int ServingScore { get; set; }
        public int FoodScore { get; set; }
        public string Comment { get; set; }
        [ForeignKey("Bill")]
        public Guid BillId { get; set; }
    }
}
