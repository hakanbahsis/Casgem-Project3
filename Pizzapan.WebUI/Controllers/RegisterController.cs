using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.WebUI.Models;
using System;
using System.Threading.Tasks;

namespace Pizzapan.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IRegisterService _registerService;

        public RegisterController(UserManager<AppUser> userManager, IRegisterService registerService)
        {
            _userManager = userManager;
            _registerService = registerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            Random rnd=new Random();
            int code=rnd.Next(100000,1000000);
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Mail,
                UserName = model.Username,
                ConfirmCode = code
            };
            if (model.Password == model.PasswordConfirm)
            {
                var result = await _userManager.CreateAsync(appUser, model.Password);
                
                if (result.Succeeded)
                {
                    _registerService.SendMail(model.Mail,"Doğrulama Kodu",code.ToString());
                    TempData["Mail"] = model.Mail;
                    return RedirectToAction("ConfirmCode", "Register");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Şifreler eşleşmiyor");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmCode()
        {
            var value = TempData["Mail"];
            ViewBag.Mail = value;
          
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ConfirmCode(UserConfirmCodeViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Mail);
            if (user.ConfirmCode == model.ConfirmCode)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
            return View();
           
        }
    }
}
