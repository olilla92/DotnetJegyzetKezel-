using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Backend.Models
{
    public class Notes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content {  get; set; } = string.Empty;
        [Required]
        public bool IsPublic { get; set; } = false;
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ForeignKey(nameof(Users))]
        public int UserId { get; set; }
        public Users Users { get; set; } = null!;

    }
}
