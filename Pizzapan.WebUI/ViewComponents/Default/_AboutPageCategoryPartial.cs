using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _AboutPageCategoryPartial:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _AboutPageCategoryPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGetAll();
            return View(values);
        }
    }
}
