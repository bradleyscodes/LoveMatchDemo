using Microsoft.AspNetCore.Mvc;
using LoveMatchDemo.Models;

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
        public IActionResult<IEnumerable<Game>> GetGames()
        {   
            var games = _context.Game.ToList();
            return Ok(games);
        }
    }
}
