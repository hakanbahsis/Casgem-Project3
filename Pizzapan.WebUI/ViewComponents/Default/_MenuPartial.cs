using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Concrete;
using System.Linq;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _MenuPartial:ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly PizzapanContext _context;

        public _MenuPartial(ICategoryService categoryService, PizzapanContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values=_context.Categories.Include(x=>x.Products).ToList();
            return View(values);
        }
    }
}
