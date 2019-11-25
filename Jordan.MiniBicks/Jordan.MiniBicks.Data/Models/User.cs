 using System.ComponentModel.DataAnnotations;

namespace Jordan.MiniBicks.Data.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Role Role { get; set; }
        public int SuperieurId { get; set; }
    }
}
