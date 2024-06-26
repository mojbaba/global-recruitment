using System.Collections.Frozen;
using System.Text;
using GlobalRecruitment.Console.Clients;
using Spectre.Console;

namespace GlobalRecruitment.Console.Services;

public enum Decision
{
    NextCandidate,
    AcceptCandidate,
    Finish
}

public class CandidateDicider
{
    private readonly Dictionary<string, string> _technologies;
    private readonly HashSet<string> _wantedExperiences;

    public CandidateDicider(IEnumerable<Technology> technologies, IEnumerable<Experience> wantedExperiences)
    {
        _technologies = technologies.ToDictionary(a => a.Guid, a => a.Name);
        _wantedExperiences = wantedExperiences.Select(a => a.TechnologyId).ToHashSet();
    }

    public Decision DisplayDecision(Candidate candidate)
    {
        var root = new Tree("Candidate");

        root.AddNode($"Full Name: [green bold]{candidate.FullName}[/]");

        var gender = candidate.Gender == 0 ? "Male" : "Female";

        root.AddNode($"Gender: [bold]{gender}[/]");

        var experienceTable = new Table()
            .RoundedBorder()
            .AddColumn("Technology")
            .AddColumn("Years");

        foreach (var candidateExperience in candidate.Experience)
        {
            var (techName, years) = _wantedExperiences.Contains(candidateExperience.TechnologyId) switch
            {
                true => ($"[green bold]{_technologies[candidateExperience.TechnologyId]} *[/]",
                    $"[green bold]{candidateExperience.YearsOfExperience}[/]"),
                false => ($"{_technologies[candidateExperience.TechnologyId]}",
                    $"{candidateExperience.YearsOfExperience.ToString()}")
            };

            experienceTable.AddRow(techName, years);
        }

        root.AddNode("Experience").AddNode(experienceTable);

        // Render the tree
        AnsiConsole.Write(root);
        
        var decision = AnsiConsole.Prompt(
            new SelectionPrompt<Decision>()
                .Title("What do you want to do?")
                .PageSize(3)
                .AddChoices(new[]
                {
                    Decision.NextCandidate,
                    Decision.AcceptCandidate,
                    Decision.Finish,
                })
        );

        return decision;
    }
}