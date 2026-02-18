using Microsoft.AspNetCore.Http.HttpResults;

namespace Backend_Challenge.Models
{
    public class Issues
    {
        // properties of the Issues model
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string status{ get; set; } = string.Empty;
        public DateTime createdAt { get; set; }

    }
}
