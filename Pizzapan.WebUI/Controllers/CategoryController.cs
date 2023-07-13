using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;

namespace Pizzapan.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values=_categoryService.TGetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.TAdd(category);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values=_categoryService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.TUpdate(category);
                return RedirectToAction("Index");
            }
            return View();
        }
        
     
        public IActionResult DeleteCategory(int id)
        {
            if (ModelState.IsValid)
            {
               var values= _categoryService.TGetById(id);
                _categoryService.TRemove(values);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
