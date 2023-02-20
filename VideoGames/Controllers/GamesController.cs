namespace VideoGames.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {

        private readonly GamesService _gs;

        public GamesController(GamesService gs)
        {
            _gs = gs;
        }

        [HttpGet]

        public ActionResult<List<Game>> Get()
        {
            try
            {
                List<Game> games = _gs.Get();
                return Ok(games);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }


        }
    }
}