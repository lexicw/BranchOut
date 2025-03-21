using System.ComponentModel.DataAnnotations.Schema;

namespace BranchOut.Data.Models
{
    public class Gradient
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public string? CssClass { get; set; }
        public string? CssGradientValue { get; set; }

        [NotMapped]
        public bool IsSelected { get; set; }
    }
}
