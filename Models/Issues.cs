using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;

namespace Backend_Challenge.Models
{
    public class Issues
    {
        // properties of the Issues model
        [Required]
        [StringLength(100)]
        public string title { get; set; } = string.Empty;

        [Required]
        [StringLength(350)]
        public string description { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string status{ get; set; } = string.Empty;

    }
}
