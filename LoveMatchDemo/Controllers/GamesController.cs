using Microsoft.AspNetCore.Mvc;
using LoveMatchDemo.Models;
using LoveMatchDemo.Data;

namespace LoveMatchDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class GamesController : Controller
    {
        private readonly DataContext _context;

        public GamesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Game>> GetGames()
        {   
            var games = _context.Games.ToList();
            return Ok(games);
        }
    }
}
