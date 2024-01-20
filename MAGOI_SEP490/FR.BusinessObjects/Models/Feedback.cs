using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGOI.BusinessObjects.Models
{
    public partial class Feedback
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ServingScore { get; set; }
        public int FoodScore { get; set; }
        public string Comment { get; set; }
    }
}
