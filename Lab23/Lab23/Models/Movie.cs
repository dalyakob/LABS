using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab23.Models
{
    public class Movie
    {
        public Movie()
        {
        }

        public int MovieID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(24)")]
        public GenreType Genre { get; set; }

        
        public double Runtime { get; set; }
    }
}
