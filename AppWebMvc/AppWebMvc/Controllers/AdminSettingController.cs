using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers
{
    public class AdminSettingController : Controller
    {
        public IActionResult Index()
        {
            // Admin'in Ayarlar Action'u
            return View();
        }
    }
}
