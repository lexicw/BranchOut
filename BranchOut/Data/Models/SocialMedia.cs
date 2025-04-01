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
        public SocialMediaPlatform Platform { get; set; }
        public string URL { get; set; }
    }

    public enum SocialMediaPlatform
    {
        Facebook,
        Github,
        Instagram,
        LinkedIn,
        Threads,
        TikTok,
        Twitter,
        YouTube
    }
}
