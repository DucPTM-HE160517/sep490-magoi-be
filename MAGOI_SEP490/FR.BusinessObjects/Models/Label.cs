using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FR.BusinessObjects.Models.Base;

namespace FR.BusinessObjects.Models
{
    public partial class Labels : ModelBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Label { get; set; }
    }
}
