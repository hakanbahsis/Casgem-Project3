using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _BlockPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
