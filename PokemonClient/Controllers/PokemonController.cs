using Microsoft.AspNetCore.Mvc;
using PokemonClient.Models;
using System.Collections.Generic;

namespace PokemonClient.Controllers
{
	public class PokemonController : Controller
	{
		// GET version/pokemon
		[Route("v{version}/pokemon")]
		public IActionResult Index()
		{
			List<Pokemon> allPokemon = Pokemon.GetPokemon();
			return View(allPokemon);
		}

		[Route("v{version}/pokemon/details/{id}")]
		public IActionResult Details(int id)
		{
			Pokemon pokemon = Pokemon.GetDetails(id);
			return View(pokemon);
		}
	}
}