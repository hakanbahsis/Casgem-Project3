using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _FoodPartial:ViewComponent
    {
        private readonly IProductService _productService;

        public _FoodPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productService.TGetAll();
            return View(values); 
        }
    }
}
