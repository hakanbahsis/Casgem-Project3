using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Concrete;
using Pizzapan.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _ContactPageInfoPartial:ViewComponent
    {
        private readonly PizzapanContext _context;
        private readonly IContactService _contactService;

        public _ContactPageInfoPartial(PizzapanContext context, IContactService contactService)
        {
            _context = context;
            _contactService = contactService;
        }

      
        public IViewComponentResult Invoke()
        {
            IEnumerable<CompanyInfo> company= new List<CompanyInfo>();
            company = _context.CompanyInfos.Take(1).ToList();
            ViewBag.Company = company;

            var map=_context.CompanyInfos.Select(x => x.MapInfo);
            ViewBag.Map = map;

            return View();
        }

        //[HttpPost]
        //public IViewComponentResult InvokeAsync(Contact contact)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _contactService.TAdd(contact);
        //        return View();
        //    }
        //    return View();
        //}
    }
}
