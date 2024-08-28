using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieSearcher.Server.Services;

namespace MovieSearcher.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : Controller
    {
        ActorService _actorService;
        public ActorController(ActorService actorService)
        {
            _actorService = actorService;
        }
        [HttpGet]
        public JsonResult GetActors()
        {
            return Json(_actorService.GetActors());
        }
    }
}
