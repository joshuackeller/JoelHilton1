using System;
using System.ComponentModel.DataAnnotations;

namespace JoelHilton1.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
