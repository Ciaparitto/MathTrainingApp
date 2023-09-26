using Microsoft.AspNetCore.Identity;

namespace MathTrainingApp.Models
{
	public class UserModel : IdentityUser
	{
		public int SkillLvl { get; set; }  = 1;
		public int GoodAnswers { get; set; } = 0;
		public int BadAnswers { get; set; } = 0;
		public int AllAnswers { get; set; } = 0;
		public int Exp { get; set; } = 0;
		
	}
}
