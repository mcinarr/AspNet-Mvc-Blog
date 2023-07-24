using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers
{
    public class UserAuthController : Controller
    {
        public IActionResult Register()
        {
            // User'ın Kaydol Action'u
            return View();
        }

        public IActionResult Login(string? redirectUrl)
        {
            // User'ın Giriş Yapma Action'u
            return View();
        }

        public IActionResult ForgotPassword()
        {
            // User'ın Şifremi Unuttum Action'u
            return View();
        }
    }
}
