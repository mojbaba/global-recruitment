// See https://aka.ms/new-console-template for more information

using GlobalRecruitment.Console;
using GlobalRecruitment.Console.Clients;
using GlobalRecruitment.Console.Services;
using Spectre.Console;

var technologyClient = new TechnologyClient();
var candidateClient = new CandidateClient();

IEnumerable<Technology> technologies = null;

// Asynchronous
await AnsiConsole.Status()
    .StartAsync("Loading Technologies...", async ctx => 
    {
        // Omitted
        technologies = await technologyClient.GetTechnologiesAsync();
    });


var wantedExperiences = new ExperienceRequirementSelector(technologies).SelectExperienceRequirements();

var decisionDisplayService = new CandidateDicider(technologies, wantedExperiences );


List<Candidate> acceptedCandidates = new();

var candidates = await candidateClient.GetCandidatesAsync();

foreach (var candidate in candidates)
{
    if(decisionDisplayService.DisplayDecision(candidate))
    {
        acceptedCandidates.Add(candidate);
    }
}


