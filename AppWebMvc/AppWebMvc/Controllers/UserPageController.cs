using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers
{
    public class UserPageController : Controller
    {
        public IActionResult Detail(int? id)
        {
            // User'ın Sayfa Detay Action'u

            return View();
        }
    }
}
