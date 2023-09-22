using Microsoft.AspNetCore.Mvc;
using MathTrainingApp.Models;


namespace MathTrainingApp.Controllers
{
    public class Training : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Task(int SkillLvl) 
        {
        TaskModel task = null;
        int TaskDifficult;
        int a,b;
        
        Random random = new Random();
            if (SkillLvl < 18)
            {
                TaskDifficult = random.Next(SkillLvl);
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
        
    }
}
