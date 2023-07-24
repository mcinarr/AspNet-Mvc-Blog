using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers.AdminControllers
{
	public class AdminUserController : Controller
	{
		public IActionResult Index()
		{
			// Admin'in Kullanıcı Yönetim Action'u
			return View();
		}
	}
}
