using Microsoft.AspNetCore.Mvc;
using MathTrainingApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;



namespace MathTrainingApp.Controllers
{
    public class TrainingController : Controller
    {
      
		private readonly UserManager<UserModel> _userManager;
        private readonly DbContextMath _context;
        public TrainingController(UserManager<UserModel> userManager,DbContextMath context)
        {
            _userManager = userManager;
            _context = context;
        }
		
		public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Task(int SkillLvl) 
        {
        var USER = _userManager.GetUserAsync(User).Result;
        if(USER != null) 
            {
                SkillLvl = USER.SkillLvl;
            }
            else
            {
                SkillLvl = 0;
            }
      
        TaskModel task = null;
        int TaskDifficult;
        int a,b;
        
        Random random = new Random();
            if (SkillLvl < 18)
            {
                TaskDifficult = random.Next(1, SkillLvl);
            } else
            {
                int[] Intarray = { 9, 10, 11, 12, 15, 16 };
                TaskDifficult = Intarray[random.Next(Intarray.Length)];
            }

            switch (TaskDifficult)
            {
                case 1:
                    a = random.Next(1, 10);
                    b = random.Next(1, 10);
                    task = new TaskModel { answer = a + b, description = $"{a} + {b}" };
                    break;
                case 2:
                    a = random.Next(1, 50);
                    b = random.Next(1, 50);
                    task = new TaskModel { answer = a + b, description = $"{a} + {b}" };
                    break;
                case 3:
                    a = random.Next(1, 10);
                    b = random.Next(1, 10);
                    while (b > a) b = random.Next(1, 10);
                    task = new TaskModel { answer = a - b, description = $"{a} - {b}" };
                    break;
                case 4:
                    a = random.Next(1, 50);
                    b = random.Next(1, 50);
                    while (b > a) b = random.Next(1, 50);
                    task = new TaskModel { answer = a - b, description = $"{a} - {b}" };
                    break;
                case 5:
                    a = random.Next(1, 5);
                    b = random.Next(1, 5);
                    task = new TaskModel { answer = a * b, description = $"{a} * {b}" };
                    break;
                case 6:
                    a = random.Next(1, 11);
                    b = random.Next(1, 11);
                    task = new TaskModel { answer = a * b, description = $"{a} * {b}" };
                    break;
                case 7:
                    a = random.Next(1, 25);
                    b = random.Next(1, 5);
                    while (a % b == 0) { a = random.Next(1, 25); b = random.Next(1, 5); }
                    task = new TaskModel { answer = a / b, description = $"{a} / {b}" };
                    break;
                case 8:
                    a = random.Next(1, 50);
                    b = random.Next(1, 10);
                    while (a % b == 0) { a = random.Next(1, 50); b = random.Next(1, 10); }
                    task = new TaskModel { answer = a / b, description = $"{a} / {b}" };
                    break;
                case 9:
                    a = random.Next(1, 200);
                    b = random.Next(1, 200);
                    task = new TaskModel { answer = a + b, description = $"{a} + {b}" };
                    break;
                case 10:
                    a = random.Next(1, 200);
                    b = random.Next(1, 200);
                    while (a > b) b = random.Next(1, 200);
                    task = new TaskModel { answer = a - b, description = $"{a} - {b}" };
                    break;
                case 11:
                    a = random.Next(1, 30);
                    b = random.Next(1, 30);
                    task = new TaskModel { answer = a * b, description = $"{a} * {b}" };
                    break;
                case 12:
                    a = random.Next(1, 250);
                    b = random.Next(1, 50);
                    while (a % b == 0) { a = random.Next(1, 250); b = random.Next(1, 200); }
                    task = new TaskModel { answer = a / b, description = $"{a} / {b}" };
                    break;
                case 13:
                    a = random.Next(1, 10);
                    b = random.Next(1, 5);
                    task = new TaskModel { answer = (int)Math.Pow(a, b), description = $"{a} ^ {b}" };
                    break;
                case 14:
                    double Number = Math.Sqrt(random.Next(1, 36));
                    while (Number % 1 == 0) Number = Math.Sqrt(random.Next(1, 36));
                    task = new TaskModel { answer = (int)Number, description = $"√{Number}" };
                    break;
                case 15:
                    a = random.Next(1, 50);
                    b = random.Next(1, 10);
                    task = new TaskModel { answer = (int)Math.Pow(a, b), description = $"{a} ^ {b}" };
                    break;
                case 16:
                    Number = Math.Sqrt(random.Next(1, 36));
                    while (Number % 1 == 0) Number = Math.Sqrt(random.Next(1, 36));
                    task = new TaskModel { answer = (int)Number, description = $"√{Number}" };
                    break;
            }

            return View(task);
        }
        [HttpPost]
        public IActionResult Task(TaskModel Task, int UserAnswer)
        {
            var USER = _userManager.GetUserAsync(User).Result;
            if (USER.SkillLvl <= 10)
            {
                if (USER.Exp >= 10)
                {
                    USER.Exp = 0;
                    USER.SkillLvl++;
                }
            }
            else
            {
                if (USER.Exp >= 20)
                {
                    USER.Exp = 0;
                    USER.SkillLvl++;
                }

            }
          
            if (ModelState.IsValid)
            {
                if (Task.answer == UserAnswer && USER != null)
                {  
                        USER.GoodAnswers++;
                        USER.AllAnswers++;
                        USER.Exp++;
                }
                else
                {
					USER.BadAnswers++;
                    USER.AllAnswers++;
                }
                
                _context.SaveChanges();
                return RedirectToAction("Task", "Training");
            }
            
			return RedirectToAction("Task", "Training");
		}
    }
}
