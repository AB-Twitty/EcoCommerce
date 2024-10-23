using Eco.Web.Models.Customer;
using Microsoft.AspNetCore.Mvc;

namespace Eco.Web.Controllers
{
	public class CustomerController : Controller
	{
		public IActionResult Login(string returnUrl)
		{
			//prepare login model 
			var model = new LoginModel();

			//check curr customer if registered

			//render view
			return View(model);
		}

	}
}
