using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public partial class BillStatus
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillStatusID { get; set; }
        public string Title { get; set; }
    }
}
