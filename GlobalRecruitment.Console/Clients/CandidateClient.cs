using System.Text.Json;
using RestSharp;

namespace GlobalRecruitment.Console.Clients;



public class CandidateClient : ICandidateClient
{
    public async Task<IEnumerable<Candidate>> GetCandidates()
    {
        var client = new RestClient("https://localhost:5001/api/");
        var request = new RestRequest("candidates", Method.Get);
        var response = await client.ExecuteAsync(request);
        var content = response.Content;

        return JsonSerializer.Deserialize<IEnumerable<Candidate>>(content);
    }
}