using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BranchOut.Data.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProfileId { get; set; }
        [ForeignKey("ProfileId")]
        public string Facebook { get; set; }
        public string Github { get; set; }
        public string Instagram { get; set; }
        public string LinkedIn { get; set; }
        public string TikTok { get; set; }
        public string Twitter { get; set; }
        public string YouTube { get; set; }
    }
}
