namespace BranchOut.Data
{
    public class Link
    {
        public int Id { get; set; }
        public string? UserID { get; set; }
        public string Name { get; set; }
        public string? URL { get; set; }
        public int Sort { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
