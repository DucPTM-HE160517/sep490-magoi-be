using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGOI.BusinessObjects.Models
{
    public partial class FoodCharacteristics
    {
        [ForeignKey("Food")]
        public int FoodId { get; set; }
        [ForeignKey("Characteristics")]
        public int CharacteristicId { get; set; }
    }
}
