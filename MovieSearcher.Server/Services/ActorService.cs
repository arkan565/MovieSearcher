using MovieSearcher.Server.Data.Repositories;
using MovieSearcher.Server.db;

namespace MovieSearcher.Server.Services
{
    public class ActorService
    {
        private MovieContext _db;
        public ActorService(MovieContext db)
        {
            _db = db;
        }

        public List<ActorRepository> GetActors()
        {
            return _db.Actors.ToList();
        }
        public void AddActor(ActorRepository actor)
        {
            _db.Actors.Add(actor);
            _db.SaveChanges();
        }
        public void RemoveActor(ActorRepository actor)
        {
            _db.Actors.Remove(actor);
            _db.SaveChanges();
        }
        public void UpdateActor(ActorRepository actor)
        {
            _db.Actors.Update(actor);
            _db.SaveChanges();
        }
    }
}
