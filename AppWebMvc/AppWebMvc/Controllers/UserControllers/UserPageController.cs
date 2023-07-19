using Microsoft.AspNetCore.Mvc;

namespace AppWebMvc.Controllers.UserControllers
{
	public class UserPageController : Controller
	{
		public IActionResult Detail(int? id)
		{
			// User'ın Sayfa Detay Controller'ı
			
			return View();
		}
	}
}
