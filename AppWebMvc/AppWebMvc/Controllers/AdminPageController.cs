using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers
{
    public class AdminPageController : Controller
    {
        public IActionResult Index()
        {
            // Admin'in Sayfa Yönetim Action'u
            return View();
        }
    }
}
