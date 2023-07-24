using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers
{
    public class UserHomeController : Controller
    {
        // User'ın AnaSayfa Action'u
        public IActionResult Index()
        {
            return View();
        }
    }
}
