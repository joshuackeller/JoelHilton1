using System;
using System.ComponentModel.DataAnnotations;

namespace JoelHilton1.Models
{
    public class AddMovieModel
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public int MovieRatingId { get; set; }
        public Rating Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [StringLength(25, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string Notes { get; set; }
    
    }
}
