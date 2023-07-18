using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using System.Linq;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _TestimonialsPartial:ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _TestimonialsPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke() 
        {
            var values = _testimonialService.TGetAll();
            return View(values); 
        }
    }
}
