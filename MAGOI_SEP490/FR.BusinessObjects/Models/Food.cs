using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FR.BusinessObjects.Models
{
    public partial class Food : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("FoodCategory")]
        public int FoodCategoryId { get; set; }
        public bool IsActive { get; set; }
    }
}
