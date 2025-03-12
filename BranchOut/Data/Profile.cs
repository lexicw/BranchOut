namespace BranchOut.Data
{
    public class Profile
    {
        public int Id { get; set; }
        public string UserID { get; set; }
        public string? ProfileImage { get; set; }
        public string? Message { get; set; }
        public string? Theme { get; set; }
        public string? Gradient { get; set; }
        public string? BackgroundColor { get; set; }
        public ICollection<Link> Links { get; set; } = new List<Link>();
        public ApplicationUser? ApplicationUser { get; set; }
        public string? Font { get; set; }
        public string? TextColor { get; set; }
        public string? ButtonRoundness { get; set; }
        public string? ButtonBorder { get; set; }
        public string? ButtonColor { get; set; }
        public string? ButtonTextColor { get; set; }
        public string? ButtonBorderColor { get; set; }
        public string? ButtonEffect { get; set; }
        public ICollection<SocialMedia> SocialMedia { get; set; } = new List<SocialMedia>();
    }
}
