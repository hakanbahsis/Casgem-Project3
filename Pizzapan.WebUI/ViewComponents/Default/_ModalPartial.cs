using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _ModalPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
