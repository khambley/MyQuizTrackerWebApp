using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyQuizTrackerWebApp.Models
{
	public class DataRepository : IRepository
	{
		private List<Question> data = new List<Question>();

		public IEnumerable<Question> Questions => data;

		public void AddQuestion(Question question)
		{
			this.data.Add(question);
		}
	}
}
