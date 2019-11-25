using System.ComponentModel.DataAnnotations;

namespace Jordan.MiniBicks.Data.Models
{
    public class Absence
    {
        [Key] 
        public int AbsenceId { get; set; }

        public string Libelle { get; set; }
    }
}
