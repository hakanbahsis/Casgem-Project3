using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _AboutPageOurTeamPartial:ViewComponent
    {
        private readonly IOurTeamService _teamService;

        public _AboutPageOurTeamPartial(IOurTeamService teamService)
        {
            _teamService = teamService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_teamService.TGetAll();
            return View(values);
        }
    }
}
