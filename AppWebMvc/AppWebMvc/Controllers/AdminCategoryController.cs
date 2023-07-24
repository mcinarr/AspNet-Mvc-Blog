using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers
{
    public class AdminCategoryController : Controller
    {
        public IActionResult Index()
        {
            // Admin'in Category Action'u
            return View();
        }
    }
}
