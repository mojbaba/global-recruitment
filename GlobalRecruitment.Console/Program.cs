// See https://aka.ms/new-console-template for more information

using GlobalRecruitment.Console;
using GlobalRecruitment.Console.Clients;
using GlobalRecruitment.Console.Services;
using Spectre.Console;

var technologyClient = new TechnologyClient();
var candidateClient = new CandidateClient();

IEnumerable<Technology> technologies = null;

await AnsiConsole.Status()
    .StartAsync("Loading Technologies...",
        async ctx => { technologies = await technologyClient.GetTechnologiesAsync(); });


var wantedExperiences = new ExperienceRequirementSelector(technologies).SelectExperienceRequirements();

var decisionDisplayService = new CandidateDicider(technologies, wantedExperiences);

var matchService = new MatchService(technologies, candidateClient);

List<Candidate> acceptedCandidates = new();

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

    if(candidates.Count() == 0)
    {
        AnsiConsole.MarkupLine("No more candidates to display.");
    }
    
    AnsiConsole.Progress()
        .Start(ctx =>
        {
            var processingCandidates = ctx.AddTask("[green]Processing candidates...[/]");
            processingCandidates.MaxValue = candidates.Count();

            foreach (var candidate in candidates)
            {
                processingCandidates.Increment(1);
                AnsiConsole.Clear();
                var decision = decisionDisplayService.DisplayDecision(candidate);

                if (decision == Decision.AcceptCandidate)
                {
                    acceptedCandidates.Add(candidate);
                }
                else if (decision == Decision.Finish)
                {
                    loadMore = false;
                    break;
                }
            }
        });
    
    if(loadMore && AnsiConsole.Confirm("Do you want to load more candidates?"))
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