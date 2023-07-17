using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.WebUI.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System;

namespace Pizzapan.WebUI.Controllers
{
  
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        #region eski
        //[HttpPost]
        //public async Task<IActionResult> Index(LoginViewModel login)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        var result = await _signInManager.PasswordSignInAsync(login.Username, login.Password, true, true);
        //        if (result.Succeeded)
        //        {
        //            var claims = new List<Claim>
        //            {
        //                new Claim(ClaimTypes.Name,login.Username)
        //            };

        //            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        //            var authProperties = new AuthenticationProperties()
        //            {
        //                IsPersistent = true,
        //                ExpiresUtc = DateTime.UtcNow.AddMinutes(1)
        //            };
        //            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new System.Security.Claims.ClaimsPrincipal(claimsIdentity), authProperties);

        //            return RedirectToAction("Index", "Category");
        //        }
        //        else
        //        {
        //            return RedirectToAction("Index", "Login");
        //        }
        //    }

        //    return View();
        //}
        #endregion


        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, true, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Category");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
