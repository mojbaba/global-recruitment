using System.Text.Json;
using RestSharp;

namespace GlobalRecruitment.Console.Clients;

public class TechnologyClient : ITechnologyClient
{
    public async Task<IEnumerable<Technology>> GetTechnologies()
    {
        var client = new RestClient("https://localhost:5001/api/");
        var request = new RestRequest("technologies", Method.Get);
        var response = await client.ExecuteAsync(request);
        var content = response.Content;

        return JsonSerializer.Deserialize<IEnumerable<Technology>>(content);
    }
}