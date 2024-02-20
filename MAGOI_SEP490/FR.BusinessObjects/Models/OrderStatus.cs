using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FR.BusinessObjects.Models
{
    public enum OrderStatusId : int
    {
        InProgress = 1,
        Finished = 2
    }
    public partial class OrderStatus
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
