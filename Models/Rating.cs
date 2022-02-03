using System;
using System.ComponentModel.DataAnnotations;
namespace JoelHilton1.Models
{
    public class Rating
    {
        [Key]
        [Required]
        public int MovieRatingId { get; set; }
        public string MovieRating { get; set; }
    }
}
