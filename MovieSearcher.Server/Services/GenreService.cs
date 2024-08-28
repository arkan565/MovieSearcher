using MovieSearcher.Server.Data.Repositories;
using MovieSearcher.Server.db;

namespace MovieSearcher.Server.Services
{
    public class GenreService
    {
        private MovieContext _db;
        public GenreService(MovieContext db)
        {
            _db = db;
        }


        public List<GenreRepository> GetGenres()
        {
            

            return _db.Genres.ToList();
        }
        public void AddGenre(GenreRepository genre)
        {
            _db.Genres.Add(genre);
            _db.SaveChanges();
        }
        public void RemoveGenre(GenreRepository genre)
        {
            _db.Genres.Remove(genre);
            _db.SaveChanges();
        }
        public void UpdateGenre(GenreRepository genre)
        {
            _db.Genres.Update(genre);
            _db.SaveChanges();
        }
       
    }
}
