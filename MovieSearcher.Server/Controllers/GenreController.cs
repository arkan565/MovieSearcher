using Microsoft.AspNetCore.Mvc;
using MovieSearcher.Server.Services;

namespace MovieSearcher.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : Controller
    {
        GenreService _genreService;
        public GenreController(GenreService genreService)
        {
            _genreService = genreService;
        }
        [HttpGet]
        public JsonResult GetGenres()
        {
            return Json(_genreService.GetGenres());
        }
    }
}
