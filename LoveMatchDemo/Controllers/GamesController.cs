using Microsoft.AspNetCore.Mvc;

namespace LoveMatchDemo.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
