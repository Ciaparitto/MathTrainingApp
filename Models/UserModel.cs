using Microsoft.AspNetCore.Identity;

namespace MathTrainingApp.Models
{
	public class UserModel : IdentityUser
	{
		public int SkillLvl = 1;
		public int GoodAnswers = 0;
		public int BadAnswers = 0;
		public int AllAnswers = 0;
	}
}
