using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]    
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }        
        public DateTime DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        [Required]
        [Range(1,20,ErrorMessage ="Number in stock must be between 1 and 20")]
        public int NumerIsStock { get; set; }
        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }
    }
}