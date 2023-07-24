using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers
{
    public class AdminUserController : Controller
    {
        public IActionResult Index()
        {
            // Admin'in Kullanıcı Yönetim Action'u
            return View();
        }
    }
}
