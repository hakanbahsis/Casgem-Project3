using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _DomainPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
