using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PokemonClient.Models
{
	public class Pokemon
	{
		public int PokemonId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public static List<Pokemon> GetPokemon()
		{
			Task<string> apiCallTask = ApiHelper.GetAll();
			string result = apiCallTask.Result;

			System.Console.WriteLine("Result: " + result);

			JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
			List<Pokemon> pokemonList = JsonConvert.DeserializeObject<List<Pokemon>>(jsonResponse.ToString());

			return pokemonList;
		}
	}
}