using System.ComponentModel.DataAnnotations;

namespace Pizzapan.WebUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz.")]
        public string Password { get; set; }
    }
}
