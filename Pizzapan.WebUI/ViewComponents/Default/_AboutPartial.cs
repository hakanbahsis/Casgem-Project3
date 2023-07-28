using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _AboutPartial:ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke() 
        {
            var values = _aboutService.TGetAll();
           return View(values); 
        }

    }
}
