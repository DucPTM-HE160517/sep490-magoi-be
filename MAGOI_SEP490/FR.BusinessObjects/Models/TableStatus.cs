using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FR.BusinessObjects.Models
{
    public enum TableStatusId : int
    {
        Available = 1,
        Serving = 2,
        Booked = 3
    }
    
    public partial class TableStatus
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
