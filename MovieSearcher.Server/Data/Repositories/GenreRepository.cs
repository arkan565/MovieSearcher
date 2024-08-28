using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MovieSearcher.Server.Data.Repositories
{
    public class GenreRepository
    {
        [Key]
        public int GenreId { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        public required string Genre { get; set; }
        public ICollection<MovieRepository> Movies { get; set; } = [];
    }
}
