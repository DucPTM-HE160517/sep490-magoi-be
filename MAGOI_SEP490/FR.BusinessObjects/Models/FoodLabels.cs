using System.ComponentModel.DataAnnotations.Schema;

namespace FR.BusinessObjects.Models
{
    public partial class FoodLabels
    {
        [ForeignKey("Food")]
        public int FoodId { get; set; }
        [ForeignKey("Labels")]
        public int LabelId { get; set; }
    }
}
