using App.Web.Mvc.Data.Entity;
using AppWebMvc.Data;
using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppWebMvc.Controllers
{
    public class UserAuthController : Controller
    {
		private readonly AppDbContext _context;
		public IActionResult Register(AppDbContext context)
        {
            User user = new User();

            if(ModelState.IsValid)
            {
				var user1 = new User()
				{
					UserName = user.UserName,
					UserSurname = user.UserSurname,
					UserNickName = user.UserNickName,
					UserPhoneNumber = user.UserPhoneNumber,
					UserEmail = user.UserEmail,
					UserPassword = user.UserPassword
				};

				_context.Users.Add(user1);
				_context.SaveChanges();

				return RedirectToAction("Index", "Home");

			}
            else
            {
				return View(context);
			}

            

            




			
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
