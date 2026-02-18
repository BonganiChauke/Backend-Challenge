namespace Backend_Challenge.Models
{
    public class IssuesCr
    {
        // properties of the Issues model
        public int id { get; set; }
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public DateTime createdAt { get; set; }
    }
}
