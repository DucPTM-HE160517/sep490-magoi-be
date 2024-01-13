using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public partial class PermissionResource
    {
        [ForeignKey("Permission")]
        public int PermissionId { get; set; }
        [ForeignKey("Resource")]
        public int ResourceId { get; set; }
    }
}
