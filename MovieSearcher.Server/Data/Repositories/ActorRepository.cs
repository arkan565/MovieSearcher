using System.ComponentModel.DataAnnotations;

namespace MovieSearcher.Server.Data.Repositories
{
    public class ActorRepository
    {
        [Key]
        public int ActorId { get; set; }
        [Required(ErrorMessage = "Actor name is required")]
        public required string ActorName { get; set; }
        public ICollection<MovieRepository> Movies { get; set; } = [];   
    }
}