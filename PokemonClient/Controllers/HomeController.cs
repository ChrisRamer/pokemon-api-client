using Microsoft.AspNetCore.Mvc;

namespace PokemonClient.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet("/")]
		public ActionResult Index()
		{
			return View();
		}
	}
}