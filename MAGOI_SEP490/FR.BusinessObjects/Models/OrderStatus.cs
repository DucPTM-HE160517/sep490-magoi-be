using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FR.BusinessObjects.Models
{
    public enum OrderStatusId : int
    {
        Waiting = 1,
        InProgress = 2,
        Served = 3,
        Finished = 4
    }
    public partial class OrderStatus
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
