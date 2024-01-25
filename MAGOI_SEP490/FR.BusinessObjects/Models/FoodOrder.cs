using System.ComponentModel.DataAnnotations.Schema;

namespace FR.BusinessObjects.Models
{
    public partial class FoodOrder
    {
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [ForeignKey("Food")]
        public int FoodId { get; set; }
        public int Quantity { get; set; }
        public string? FoodNote { get; set; }
        public DateTime OrderAt { get; set; }
    }
}
