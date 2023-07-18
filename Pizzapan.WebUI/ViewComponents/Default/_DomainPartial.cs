using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _DomainPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            ViewBag.title1 = "Pizza Pizza";
            ViewBag.title2 = "En Lezzetli Pizzalar Burada!";
            return View();
        }
    }
}
