using MathTrainingApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MathTrainingApp.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<UserModel> _userManager;
		private readonly SignInManager<UserModel> _signInManager;
		public AccountController(UserManager<UserModel> userManager, SignInManager<UserModel> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Login(Login UserData)
		{
			if (ModelState.IsValid)
			{
				await _signInManager.PasswordSignInAsync(UserData.UserName, UserData.Password, false, false);
				return RedirectToAction("Index", "Home");
			}
			return View(UserData);
		}
		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}
		
		public async Task<IActionResult> Register(Register UserData)
		{
			if (ModelState.IsValid)
			{
				var NewUser = new UserModel
				{
					Email = UserData.EmailAddress,
					UserName = UserData.UserName,
				};
				await _userManager.CreateAsync(NewUser, UserData.Password);
                await _signInManager.PasswordSignInAsync(UserData.UserName, UserData.Password, false, false);
                return RedirectToAction("Index", "Home");
			}
			return View(User);
		}
		[HttpGet]
		public async Task<IActionResult> LogOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
	}
}
