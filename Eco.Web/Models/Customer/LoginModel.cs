using System.ComponentModel.DataAnnotations;

namespace Eco.Web.Models.Customer
{
	public record LoginModel
	{
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[DataType(DataType.Password)]
		public string Password { get; set; }

		public bool RememberMe { get; set; }
	}
}
