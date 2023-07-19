using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers.UserControllers
{
	public class UserCategoryController : Controller
	{
		// User'ın Kategori Controller'ı
		public IActionResult Index(int? id, int? page)
		{
			return View();
		}
	}
}
