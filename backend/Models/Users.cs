using System.ComponentModel.DataAnnotations;

namespace MyApp.Backend.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required, MaxLength(100), EmailAddress]
        public string Email { get; set; } = string.Empty ;

        [Required, MaxLength(30)]
        public string Password { get; set; } = string.Empty;

        public virtual ICollection<Notes> Notes { get; set; } = new List<Notes>();
    }
}
