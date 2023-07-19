using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers.AdminControllers
{
	public class AdminBlogController : Controller
	{
		public IActionResult Index()
		{
			// Admin'in Blog Yönetim Action'u
			return View();
		}
	}
}
