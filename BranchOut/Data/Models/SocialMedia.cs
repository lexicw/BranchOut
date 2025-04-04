using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BranchOut.Data.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProfileId { get; set; }
        [ForeignKey("ProfileId")]
        public Profile Profile { get; set; }
        public SocialMediaPlatform Platform { get; set; }
        [Required(ErrorMessage = "The URL is required")]
        [Url(ErrorMessage = "Please enter a valid URL")]
        public string URL { get; set; }
        public DateTime DateAdded { get; set; }
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
