using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BranchOut.Data.Models
{
    public class Font
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? CssClass { get; set; }

        [NotMapped]
        public bool IsSelected { get; set; }
    }
}
