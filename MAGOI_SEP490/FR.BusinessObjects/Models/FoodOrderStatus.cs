using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FR.BusinessObjects.Models
{

    public enum FoodOrderStatusId : int
    {
        Uncooked = 1,
        Cooking = 2,
        Cooked = 3
    }
    public partial class FoodOrderStatus
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
