using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public partial class UserFoodWishlist
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Food")]
        public int FoodId { get; set; }
    }
}
