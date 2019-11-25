using System.ComponentModel.DataAnnotations;

namespace Jordan.MiniBicks.Data.Models
{
    public class Remboursement
    {
        [Key]
        public int AbsenceId { get; set; }

        public string Libelle { get; set; }
    }
}
