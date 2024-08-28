using Microsoft.EntityFrameworkCore;
using MovieSearcher.Server.Data.Repositories;

namespace MovieSearcher.Server.db
{
    public class MovieContext: DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }
        public DbSet<MovieRepository> Movies { get; set; }
        public DbSet<ActorRepository> Actors { get; set; }
        public DbSet<GenreRepository> Genres{ get; set; }

    }
}
