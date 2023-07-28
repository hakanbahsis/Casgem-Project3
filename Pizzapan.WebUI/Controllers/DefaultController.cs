using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.WebUI.Controllers
{
    public class DefaultController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }
    }
}
