using GlobalRecruitment.Console;
using GlobalRecruitment.Console.Clients;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace GlobalRecruitment.Test;

public class MockedTechnologyClient : ITechnologyClient
{
    readonly string _technologiesJson = @"
    [
      {
        ""name"": ""Rust"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA04""
      },
      {
        ""name"": ""TypeScript"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA05""
      },
      {
        ""name"": ""Python"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA06""
      },
      {
        ""name"": ""Kotlin"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA07""
      },
      {
        ""name"": ""Go"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA08""
      },
      {
        ""name"": ""Julia"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA09""
      },
      {
        ""name"": ""Dart"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA10""
      },
      {
        ""name"": ""C#"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA11""
      },
      {
        ""name"": ""Swift"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA12""
      },
      {
        ""name"": ""JavaScript"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA13""
      },
      {
        ""name"": ""SQL"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA14""
      },
      {
        ""name"": ""Scala"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA15""
      },
      {
        ""name"": ""Haskell"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA16""
      },
      {
        ""name"": ""R"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA17""
      },
      {
        ""name"": ""Java"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA18""
      },
      {
        ""name"": ""C++"",
        ""guid"": ""3B85BE83-9B4E-4B15-9EB2-68363936CA19""
      }
    ]";

    public Task<IEnumerable<Technology>> GetTechnologiesAsync()
    {
        var technologies = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Technology>>(_technologiesJson);
        return Task.FromResult(technologies.AsEnumerable());
    }
}