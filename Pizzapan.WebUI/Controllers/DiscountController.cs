using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;

namespace Pizzapan.WebUI.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public IActionResult Index()
        {
            var values=_discountService.TGetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddDiscount()
        {
            Random rnd = new Random();
            char[] harf=new char[4]; ;
            string cc = "";
            string rr = "";
            for (int i = 0; i < 4; i++)
            {
               int kod = rnd.Next(65, 91);
                harf[i] += Convert.ToChar(kod);
                cc += harf[i].ToString();
            }
            for (int i = 0; i < 2; i++)
            {
                int a = rnd.Next(0, 9);
                rr += a;
            }
            string kupon = cc + rr.ToString();
            ViewBag.C = kupon;


            return View();  
        }

        [HttpPost]
        public IActionResult AddDiscount(Discount discount)
        {
           
            if (ModelState.IsValid)
            {
               
                discount.DiscountEndDate= discount.DiscountStartDate.AddDays(3);
               
                _discountService.TAdd(discount);
                return RedirectToAction("Index");   
            }
            return View(discount);
        }

        [HttpGet]
        public IActionResult UpdateDiscount(int id)
        {
            var values = _discountService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateDiscount(Discount discount)
        {

            if (ModelState.IsValid)
            {

                discount.DiscountEndDate = discount.DiscountStartDate.AddDays(3);

                _discountService.TUpdate(discount);
                return RedirectToAction("Index");
            }
            return View(discount);
        }

        public IActionResult DeleteDiscount(int id)
        {
            var values=_discountService.TGetById(id);
            _discountService.TRemove(values);
            return RedirectToAction("Index");
        }
    }
}
