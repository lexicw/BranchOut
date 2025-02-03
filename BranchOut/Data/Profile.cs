namespace BranchOut.Data
{
    public class Profile
    {
        public int ProfileID { get; set; }
        public string UserID { get; set; }
        public string Message { get; set; }
        public string Theme { get; set; }
        public ICollection<Link> Links { get; set; } = new List<Link>();
    }
}
