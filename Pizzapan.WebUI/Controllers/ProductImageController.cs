using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.WebUI.Models;
using System;
using System.IO;

namespace Pizzapan.WebUI.Controllers
{
    public class ProductImageController : Controller
    {
        private readonly IProductImageService _productImageService;

        public ProductImageController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }

      

        [HttpGet]
        public IActionResult AddProductImages()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProductImages(ImageFileViewModel model)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(model.Image.FileName);
            var imageName = Guid.NewGuid() + extension;
            var saveLocation = resource + "/wwwroot/images/" + imageName;
            using (var stream = new FileStream(saveLocation, FileMode.Create))
            {
                model.Image.CopyTo(stream);
            }
            ProductImages images = new ProductImages();
            images.ImageUrl = imageName;
            _productImageService.TAdd(images);
            return RedirectToAction("ImageList");
        }
    }
}
