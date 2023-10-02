using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Ch04Ex1MovieList.Models
{
    public class Movie
    {
        // EF Core will configure the database to generate this value
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Please eneter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1889, 2999, ErrorMessage = "Year must be after 1889.")]
        public int? Year{ get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be ebtween 1 and 5.")]
        public int? Rating { get; set; }
    }
}
