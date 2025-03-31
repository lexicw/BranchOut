using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BranchOut.Data.Models
{
    public class Gradient
    {
        public int Id { get; set; }
        [Required]
        public string? Value { get; set; }
        public string? CssClass { get; set; }

        [NotMapped]
        public bool IsSelected { get; set; }
    }
}
