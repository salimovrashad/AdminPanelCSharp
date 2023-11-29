using System.Diagnostics;
using Employee.Helpers;
using Employee.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Employee.Controllers
{
	public class HomeController : Controller
	{
		public async Task<IActionResult> Index()
		{
			var dt = await SqlHelper.GetDatas("SELECT * FROM Employees");
			return View(dt);
		}
		public IActionResult Contact()
		{
			return View();
		}
	}
}