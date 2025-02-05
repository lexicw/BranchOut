using System.ComponentModel.DataAnnotations;

namespace BranchOut.Data
{
    public class Link
    {
        public int Id { get; set; }
        public string? UserID { get; set; }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string? URL { get; set; }
        public int Sort { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Visible { get; set; }
    }
}
