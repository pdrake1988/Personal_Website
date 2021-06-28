using Microsoft.AspNetCore.Mvc;

namespace Personal_Website.Controllers
{
    public class MovieProjectController : Controller
    {
        // GET
        public IActionResult GetMovies()
        {
            return View();
        }
    }
}