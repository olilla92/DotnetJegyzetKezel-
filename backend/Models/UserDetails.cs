using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Backend.Models
{
    public class UserDetails
    {
        [Key, ForeignKey(nameof(Users))]
        public int UserId { get; set; }

        public string Address { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }

        public Users Users { get; set; } = null!;
    }
}
