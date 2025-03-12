using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BranchOut.Data.Models
{
    public class Link
    {
        public int Id { get; set; }
        public string? UserID { get; set; }
        public int ProfileId { get; set; }
        [ForeignKey("ProfileId")]
        public Profile Profile { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "The URL is required")]
        [Url(ErrorMessage = "Please enter a valid URL")]
        public string? URL { get; set; }
        public int Sort { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Visible { get; set; }
    }
}
