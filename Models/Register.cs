using System.ComponentModel.DataAnnotations;

namespace MathTrainingApp.Models
{
	public class Register
	{
		[Required]
		public string UserName { get; set; }
		[Required]
		[EmailAddress]
		public string EmailAddress { get; set; }
		[Required]
		public string Password { get; set; }


	}
}
