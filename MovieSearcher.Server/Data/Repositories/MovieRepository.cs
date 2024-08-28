using System.ComponentModel.DataAnnotations;

namespace MovieSearcher.Server.Data.Repositories
{
    public class MovieRepository
    {
        [Key]
        public int MovieId { get; set; }
        public int Year { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public required string Title { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public required string Description { get; set; }
        public required ICollection<GenreRepository> Genre { get; set; }
        public required ICollection<ActorRepository> Actors { get; set; }
    }
}
