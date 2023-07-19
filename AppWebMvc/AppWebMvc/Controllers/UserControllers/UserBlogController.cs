using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers.UserControllers
{
	public class UserBlogController : Controller
	{
		public IActionResult Search(string? query, int? page)
		{
			// User'ın Blog Arama Action'u
			
			return View();
		}

		public IActionResult Detail(int? id)
		{
			// User'ın Blog Detay Action'u
			return View();
		}
	}
}
