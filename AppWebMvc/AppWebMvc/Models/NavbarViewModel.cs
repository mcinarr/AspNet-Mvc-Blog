using App.Web.Mvc.Data.Entity;

namespace AppWebMvc.Models
{
	public class NavbarViewModel
	{

		public IEnumerable<Category> Categories { get; set; }

		public IEnumerable<Page> Pages { get; set; }
		
		public IEnumerable<User> Users { get; set; }



	}
}
