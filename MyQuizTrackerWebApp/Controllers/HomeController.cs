using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyQuizTrackerWebApp.Models;

namespace MyQuizTrackerWebApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private IRepository repository;

		public HomeController(IRepository repo, ILogger<HomeController> logger) 
		{
			repository = repo;
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View(repository.Questions);
		}

		[HttpPost]
		public IActionResult AddQuestion(Question question)
		{
			repository.AddQuestion(question);
			return RedirectToAction(nameof(Index));
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
