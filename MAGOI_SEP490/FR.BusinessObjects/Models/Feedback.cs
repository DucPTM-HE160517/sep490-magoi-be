using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FR.BusinessObjects.Models
{
    public partial class Feedback : BaseModel
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
