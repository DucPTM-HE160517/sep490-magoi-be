using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGOI.BusinessObjects.Models
{
    public partial class Food
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public float Price { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("FoodCategory")]
        public int FoodCategoryId { get; set; }
        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public bool IsAvailable { get; set; }
    }
}
