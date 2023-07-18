using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _PortfolioPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
