using System.ComponentModel.DataAnnotations;

namespace Jordan.MiniBicks.Data.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string Libelle { get; set; }
    }
}
