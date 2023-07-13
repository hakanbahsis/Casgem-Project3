using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Concrete;
using Pizzapan.EntityLayer.Concrete;
using System.Linq;

namespace Pizzapan.WebUI.Controllers
{
    public class CompanyInfoController : Controller
    {
        private readonly ICompanyInfoService _companyInfoService;
        private readonly PizzapanContext _context;

        public CompanyInfoController(ICompanyInfoService companyInfoService, PizzapanContext context)
        {
            _companyInfoService = companyInfoService;
            _context = context;
        }

        public IActionResult Index()
        {
            var countInfo = _context.CompanyInfos.Count();
            ViewBag.CountInfo = countInfo;

            var values=_companyInfoService.TGetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCompanyInfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCompanyInfo(CompanyInfo companyInfo)
        {
            if (ModelState.IsValid)
            {
                _companyInfoService.TAdd(companyInfo);
                return RedirectToAction("Index");
            }
            return View();
        }

      
        public IActionResult DeleteCompanyInfo(int id)
        {
            var values=_companyInfoService.TGetById(id);
            _companyInfoService.TRemove(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCompanyInfo(int id)
        {
            var values = _companyInfoService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCompanyInfo(CompanyInfo companyInfo)
        {
            if (ModelState.IsValid)
            {
                _companyInfoService.TUpdate(companyInfo);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
