using System.ComponentModel.DataAnnotations.Schema;

namespace FR.BusinessObjects.Models
{
    public partial class FoodOrder : BaseModel
    {
        [ForeignKey("Order")]
        public Guid OrderId { get; set; }
        [ForeignKey("Food")]
        public int FoodId { get; set; }
        [ForeignKey("FoodOrderStatus")]
        public int FoodOrderStatusId{ get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public string? FoodNote { get; set; }
        public DateTime OrderAt { get; set; }
    }
}
