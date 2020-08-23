using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyQuizTrackerWebApp.Models
{
	public class Quiz
	{
		public int QuizId { get; set; }
		public string QuizTitle { get; set; }
		public List<Question> Questions { get; set; }
	}
}
