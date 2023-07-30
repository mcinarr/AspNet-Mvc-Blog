using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers
{
    public class UserBlogPostController : Controller
    {
        public IActionResult FullWidth()
        {
            return View();
        }
        public IActionResult LeftSide()
        {
            return View();
        }
        public IActionResult RightSide()
        {
            return View();
        }
    }
}
