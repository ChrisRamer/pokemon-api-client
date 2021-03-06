using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PokemonClient.Models;
using System.Collections.Generic;

namespace PokemonClient.Controllers
{
	public class HomeController : Controller
	{
		static List<string> apiVersions = new List<string>()
		{
			"1.0",
			"2.0"
		};

		[HttpGet("/")]
		public ActionResult Index()
		{
			List<SelectListItem> versions = apiVersions.ConvertAll(v => new SelectListItem
			{
				Text = v,
				Value = v,
			});
			ViewBag.VersionList = versions;
			return View();
		}

		[HttpPost("/")]
		public ActionResult Index(SelectListItem test)
		{
			double version = double.Parse(Request.Form["VersionList"]);
			ApiHelper.ApiVersion = version;
			return RedirectToAction("Index", "Pokemon", new { version = version });
		}
	}
}