using Microsoft.AspNetCore.Mvc;
namespace portfolio_one
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult home()
        {
            return View();
        }
        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        }
        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }
        [HttpPost("p")]
        public ViewResult Chome()
        {
            return View("home");
        }
    }
}