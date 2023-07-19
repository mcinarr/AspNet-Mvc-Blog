using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers.AdminControllers
{
	public class AdminSettingController : Controller
	{
		public IActionResult Index()
		{
			// Admin'in Ayarlar Action'u
			return View();
		}
	}
}
