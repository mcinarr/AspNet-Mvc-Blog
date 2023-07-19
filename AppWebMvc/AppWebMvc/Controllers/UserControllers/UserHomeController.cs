using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers.UserControllers
{
	public class UserHomeController : Controller
	{
		// User'ın AnaSayfa Controller'ı
		public IActionResult Index()
		{
			return View();
		}
	}
}
