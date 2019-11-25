using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jordan.MiniBicks.Data.Models
{
    public class RemboursementUser
    {
        [Key]
        public Guid AbsenceUserId { get; set; } = new Guid();
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Justificatif { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Remboursement")]
        public int RemboursementId { get; set; }
        public Remboursement Remboursement { get; set; }
    }
}
