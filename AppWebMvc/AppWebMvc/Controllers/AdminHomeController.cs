using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers
{
    public class AdminHomeController : Controller
    {

        public IActionResult Index()
        {
            // Admin'in AnaSayfa Action'u
            return View();
        }
    }
}
