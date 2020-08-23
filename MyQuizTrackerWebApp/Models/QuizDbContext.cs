using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyQuizTrackerWebApp.Models
{
	public class QuizDbContext : DbContext
	{
		public QuizDbContext (DbContextOptions<QuizDbContext> options) : base(options) { }
		public DbSet<Quiz> Quizzes { get; set; }
		public DbSet<Question> Questions { get; set; }
	}
}
