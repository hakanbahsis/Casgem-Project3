using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
