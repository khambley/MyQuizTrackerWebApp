using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyQuizTrackerWebApp.Models
{
	public class Question
	{
		public int QuestionId { get; set; }
		public string QuestionText { get; set; }
		public string CorrectAnswer { get; set; }
		public string WrongAnswer1 { get; set; }
		public string? WrongAnswer2 { get; set; }
		public string? WrongAnswer3 { get; set; }
		public string? WrongAnswer4 { get; set; }

		public int QuizId { get; set; }
		public virtual Quiz Quiz { get; set; }


	}
}
