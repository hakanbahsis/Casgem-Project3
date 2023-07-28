using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using System.Linq;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    {
        private readonly ICompanyInfoService _companyInfoService;

        public _FooterPartial(ICompanyInfoService companyInfoService)
        {
            _companyInfoService = companyInfoService;
        }

        public IViewComponentResult Invoke() 
        {
            var values = _companyInfoService.TGetAll().Take(1);
            return View(values); 
        }
    }
}
