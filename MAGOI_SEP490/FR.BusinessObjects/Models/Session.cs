using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FR.BusinessObjects.Models;

public class Session
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ExpoToken { get; set; }
    public string Role { get; set; }
}