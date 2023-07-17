using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.WebUI.Models;
using System.Threading.Tasks;

namespace Pizzapan.WebUI.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var value=await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditViewModel model=new UserEditViewModel();
            model.Name=value.Name;
            model.Surname=value.Surname;
            model.Mail = value.Email;
            model.City = value.City;
            model.Username= value.UserName;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel value)
        {
            var user=await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name=value.Name;
            user.Surname=value.Surname;
            user.Email = value.Mail;
            user.City = value.City;
            user.Surname= value.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, value.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }

            return View();
        }
    }
}
