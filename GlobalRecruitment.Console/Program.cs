﻿// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using GlobalRecruitment.Console;
using GlobalRecruitment.Console.Clients;
using GlobalRecruitment.Console.Services;
using Spectre.Console;

var technologyClient = new TechnologyClient();
var candidateClient = new CandidateClient();

List<Candidate> acceptedCandidates = new();
HashSet<string> rejectedCandidates = new();



IEnumerable<Technology> technologies = null;

await AnsiConsole.Status()
    .StartAsync("Loading Technologies...",
        async ctx => { technologies = await technologyClient.GetTechnologiesAsync(); });


var wantedExperiences = new ExperienceRequirementSelector(technologies).SelectExperienceRequirements();

var decisionDisplayService = new CandidateDicider(technologies, wantedExperiences);

var matchService = new MatchService(technologies, candidateClient);

if (System.IO.File.Exists("acceptedCandidates.json"))
{
    var jsonCandidatesToLoad = System.IO.File.ReadAllText("acceptedCandidates.json");
    acceptedCandidates = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Candidate>>(jsonCandidatesToLoad);
    if (acceptedCandidates.Count > 0 &&
        AnsiConsole.Confirm("There are previously saved candidates. Do you want to load them?"))
    {
        var savedCandidatesDisplay = new SelectedCandidatesDisplay(technologies, wantedExperiences);
        savedCandidatesDisplay.Display(acceptedCandidates);
    }
}


if (System.IO.File.Exists("rejectedCandidates.json"))
{
    var jsonRejectedCandidatesToLoad = System.IO.File.ReadAllText("rejectedCandidates.json");
    rejectedCandidates = Newtonsoft.Json.JsonConvert.DeserializeObject<HashSet<string>>(jsonRejectedCandidatesToLoad);
}

bool loadMore = true;

IEnumerable<Candidate> candidates = null;


while (loadMore)
{
    await AnsiConsole.Status()
        .StartAsync("Loading Candidates...", async ctx =>
        {
            var allCandidates = await candidateClient.GetCandidatesAsync();
            candidates = await matchService.GetMatchedCandidatesAsync(wantedExperiences);
        });

    if (candidates.Count() == 0)
    {
        AnsiConsole.MarkupLine("No candidates to display.");
    }
    else
    {
        AnsiConsole.Progress()
            .Start(ctx =>
            {
                var processingCandidates = ctx.AddTask("[green]Processing candidates...[/]");
                processingCandidates.MaxValue = candidates.Count();

                foreach (var candidate in candidates)
                {
                    if (rejectedCandidates.Contains(candidate.CandidateId))
                    {
                        continue;
                    }

                    if (acceptedCandidates.Any(ac => ac.CandidateId == candidate.CandidateId))
                    {
                        continue;
                    }

                    processingCandidates.Increment(1);
                    AnsiConsole.Clear();
                    var decision = decisionDisplayService.DisplayDecision(candidate);

                    if (decision == Decision.AcceptCandidate)
                    {
                        acceptedCandidates.Add(candidate);
                    }
                    else if (decision == Decision.NextCandidate)
                    {
                        rejectedCandidates.Add(candidate.CandidateId);
                    }
                    else if (decision == Decision.Finish)
                    {
                        loadMore = false;
                        break;
                    }
                }
            });
    }


    if (loadMore && AnsiConsole.Confirm("Do you want to load more candidates?"))
    {
        loadMore = true;
    }
    else
    {
        loadMore = false;
    }
}

AnsiConsole.Clear();

var selectedCandidatesDisplay = new SelectedCandidatesDisplay(technologies, wantedExperiences);
selectedCandidatesDisplay.Display(acceptedCandidates);
var jsonCandidatesToSave = Newtonsoft.Json.JsonConvert.SerializeObject(acceptedCandidates);

System.IO.File.WriteAllText("acceptedCandidates.json", jsonCandidatesToSave);
AnsiConsole.MarkupLine("Candidates saved to [green]acceptedCandidates.json[/]");

var jsonRejectedCandidatesToSave = Newtonsoft.Json.JsonConvert.SerializeObject(rejectedCandidates);
System.IO.File.WriteAllText("rejectedCandidates.json", jsonRejectedCandidatesToSave);