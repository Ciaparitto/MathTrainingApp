using MathTrainingApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MathTrainingApp
{
	public class DbContextMath : IdentityDbContext<UserModel>
	{
		public DbContextMath(DbContextOptions<DbContextMath> options) : base(options)
		{

		}
		public DbSet<UserModel> Users;
	}
}
