using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers.UserControllers
{
	public class UserCategoryController : Controller
	{
		// User'ın Kategori Action'u
		public IActionResult Index(int? id, int? page)
		{
			return View();
		}
	}
}
