using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGOI.BusinessObjects.Models
{
    public partial class Restaurant
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Hotline { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        //public int RestaurantCategoryId { get; set; }
        //public int AvailabilityStatusId { get; set; }
    }
}
