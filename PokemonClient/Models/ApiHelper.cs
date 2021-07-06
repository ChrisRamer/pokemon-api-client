using RestSharp;
using System.Threading.Tasks;

namespace PokemonClient.Models
{
	class ApiHelper
	{
		public static async Task<string> GetAll()
		{
			RestClient client = new RestClient("http://localhost:5004/api");
			RestRequest request = new RestRequest($"1/pokemon", Method.GET);
			IRestResponse response = await client.ExecuteTaskAsync(request);
			return response.Content;
		}

		public static async Task<string> Get(int id)
		{
			RestClient client = new RestClient("http://localhost:5004/api");
			RestRequest request = new RestRequest($"pokemon/{id}", Method.GET);
			IRestResponse response = await client.ExecuteTaskAsync(request);
			return response.Content;
		}
	}
}