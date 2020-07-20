using System;
using System.ComponentModel.DataAnnotations;

namespace Lab22.Models
{
    public class MoviesModel
    {
        public MoviesModel()
        {

        }
        public MoviesModel(string title, Genre genre)
        {
            Title = title;
            Genre = genre;
        }
        [Required]
        [Display(Name = "Movie Title")]
        public string Title { get; set; }

        public Genre Genre { get; set; }
        
    }
}
