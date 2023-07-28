using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;

namespace Pizzapan.WebUI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            
            var values=_aboutService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            if (ModelState.IsValid)
            {
                _aboutService.TAdd(about);
                return RedirectToAction("Index");
            }
            return View(about);
        }

        [HttpGet]
        public IActionResult DeleteAbout(int id)
        {
            var values=_aboutService.TGetById(id);
            _aboutService.TRemove(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = _aboutService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            if (ModelState.IsValid)
            {
                _aboutService.TUpdate(about);
                return RedirectToAction("Index");
            }
            return View(about) ;
        }


    }
}
