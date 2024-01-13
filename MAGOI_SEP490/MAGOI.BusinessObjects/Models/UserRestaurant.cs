using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public partial class UserRestaurant
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
    }
}
