using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using System.Linq;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _AboutPageAboutPartial:ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutPageAboutPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.TGetAll().Take(1);
            return View(values);
        }
    }
}
