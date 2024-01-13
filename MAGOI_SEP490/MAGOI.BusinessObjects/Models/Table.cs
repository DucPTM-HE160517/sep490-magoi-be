using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Models
{
    public partial class Table
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TableID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public bool IsAvailable { get; set; }
    }
}
