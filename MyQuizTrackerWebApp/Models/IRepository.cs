using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyQuizTrackerWebApp.Models
{
	public interface IRepository
	{
		IEnumerable<Question> Questions { get;  }

		void AddQuestion(Question question);
	}
}
