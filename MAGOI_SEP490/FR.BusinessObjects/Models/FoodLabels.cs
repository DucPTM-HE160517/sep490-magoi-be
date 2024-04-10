using System.ComponentModel.DataAnnotations.Schema;

namespace FR.BusinessObjects.Models
{
    public partial class FoodLabels : BaseModel
    {
        [ForeignKey("Food")]
        public int FoodId { get; set; }
        [ForeignKey("Labels")]
        public int LabelId { get; set; }
    }
}
