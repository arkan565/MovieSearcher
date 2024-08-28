using Microsoft.EntityFrameworkCore;
using MovieSearcher.Server.Data.Repositories;
using MovieSearcher.Server.db;

namespace MovieSearcher.Server.Services
{
    public class MovieService
    {
        private MovieContext _db;
        public MovieService(MovieContext db)
        {
            _db = db;
            Populate();
        }

        public List<MovieRepository> GetMovies(string title = "", string actor = "", int? genre = null)
        {
            return _db.Movies.Where(m => m.Title.Contains(title) && m.Genre.Any(g => genre == null || g.GenreId == genre) && m.Actors.Any(a => a.ActorName.Contains(actor)))
                .Include(m => m.Actors)
                .Include(m => m.Genre).ToList();
        }
        public void AddMovie(MovieRepository movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
        }
        public void RemoveMovie(MovieRepository movie) {
            _db.Movies.Remove(movie);
            _db.SaveChanges();
        }
        public void UpdateMovie(MovieRepository movie)
        {
            _db.Movies.Update(movie);
            _db.SaveChanges();
        }
        public void populateAddMovie(string actorName , string genreName, string title, string description)
        {
            ActorRepository actor = new()
            {
                ActorName = actorName
            };
            _db.Actors.Add(actor);
            GenreRepository genre = new()
            {
                Genre = genreName
            };
            _db.Genres.Add(genre);
            MovieRepository movie = new()
            {
                Actors =
            [
             actor
            ],
                Title = title,
                Description = description,
                Genre = [
                    genre
                ]
            };
            _db.Movies.Add(movie);
        }
        public void Populate()
        {
            //TODO: this data should come from some api or make a movie
            if (_db.Movies.Any() || _db.Actors.Any() || _db.Genres.Any())
            {
                return;
            }
            else {
                populateAddMovie("Anthony Hopkins", "Horror", "Silence of the lambs", "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.");
                populateAddMovie("Elijah Wood", "Fantasy", "Lord of the rings", "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.");
                populateAddMovie("Russell Crowe", "Action Epic", "Gladiator", "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.");
                populateAddMovie("Tom Hanks", "Drama", "Forrest Gump", "The history of the United States from the 1950s to the '70s unfolds from the perspective of an Alabama man with an IQ of 75, who yearns to be reunited with his childhood sweetheart.");
                populateAddMovie("Christian Bale", "Action", "The Dark Knight", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.");
                _db.SaveChanges();
            }
        }
    }
}
