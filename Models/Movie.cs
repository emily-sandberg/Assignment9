using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment9.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Please enter the category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please enter the title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the year")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please enter the director")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Please enter the rating")]
        public string Rating { get; set; }

        public bool Edited { get; set; } //optional

        public string LentTo { get; set; } //optional

        [MaxLength(25, ErrorMessage = "Maximum number of characters is 25")]
        public string Notes { get; set; } //optional
    }
}
