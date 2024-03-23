using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FR.BusinessObjects.Models
{
    public enum PaymentMethodId : int
    {
        Cash = 1,
        Banking = 2,
        CreditCard = 3
    }
    public class PaymentMethod
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Method { get; set; }
    }
}
