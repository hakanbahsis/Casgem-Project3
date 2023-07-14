using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Concrete;
using Pizzapan.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Pizzapan.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly PizzapanContext _context;

        public ProductController(IProductService productService, PizzapanContext context)
        {
            _productService = productService;
            _context = context;
        }

        public IActionResult Index()
        {
           var values= _productService.TGetProductsWithCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> category = (from x in _context.Categories.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.Name,
                                             Value = x.CategoryId.ToString()
                                         }).ToList();
            ViewBag.Category = category;
            return View();
        }
        
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.TAdd(product);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            List<SelectListItem> category = (from x in _context.Categories.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.Name,
                                                 Value = x.CategoryId.ToString()
                                             }).ToList();
            ViewBag.Category = category;
            var values = _productService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.TUpdate(product);
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult DeleteProduct(int id)
        {
            if (ModelState.IsValid)
            {
                var values = _productService.TGetById(id);
                _productService.TRemove(values);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
