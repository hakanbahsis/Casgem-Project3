﻿using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.WebUI.ViewComponents.Default
{
    public class _HeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
