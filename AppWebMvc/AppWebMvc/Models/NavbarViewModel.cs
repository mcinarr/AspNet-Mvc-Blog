using App.Persistence.Data.Entity;

namespace App.Web.Mvc.Models
{
  public class NavbarViewModel
	{
		public IEnumerable<Category> Categories { get; set; }

		public IEnumerable<Page> Pages { get; set; }

		public IEnumerable<User> Users { get; set; }
	}
}
