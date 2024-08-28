using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieSearcher.Server.Services;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MovieSearcher.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        MovieService _movieService;
        ActorService _actorService;
        GenreService _genreService;
        public MoviesController(MovieService movieService, ActorService actorService, GenreService genreService)
        {
            _movieService = movieService;
            _actorService = actorService;
            _genreService = genreService;
        }
        [HttpGet]
        public JsonResult GetMovies(string title = "", string actor = "", int? genre = null)
        {
            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles,
            };
            return Json(_movieService.GetMovies(title, actor, genre), options);
        }
    }
}
