using RestSharp;
using System.Threading.Tasks;

namespace PokemonClient.Models
{
	class ApiHelper
	{
		static int apiVersion = 1;
		public static int ApiVersion
		{
			get
			{
				return apiVersion;
			}
			set
			{
				apiVersion = value;
			}
		}

		public static async Task<string> GetAll()
		{
			RestClient client = new RestClient("http://localhost:5004/api");
			RestRequest request = new RestRequest($"v{apiVersion}/pokemon", Method.GET);
			IRestResponse response = await client.ExecuteTaskAsync(request);
			return response.Content;
		}

		public static async Task<string> Get(int id)
		{
			RestClient client = new RestClient("http://localhost:5004/api");
			RestRequest request = new RestRequest($"v{apiVersion}/pokemon/{id}", Method.GET);
			IRestResponse response = await client.ExecuteTaskAsync(request);
			return response.Content;
		}
	}
}