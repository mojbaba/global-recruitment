using Spectre.Console;

namespace GlobalRecruitment.Console.Services;

public class SelectedCandidatesDisplay
{
    private readonly Dictionary<string, string> _technologies;
    private readonly HashSet<string> _wantedExperiences;

    public SelectedCandidatesDisplay(IEnumerable<Technology> technologies, IEnumerable<Experience> wantedExperiences)
    {
        _technologies = technologies.ToDictionary(a => a.Guid, a => a.Name);
        _wantedExperiences = wantedExperiences.Select(a => a.TechnologyId).ToHashSet();
    }

    public void Display(IEnumerable<Candidate> candidates)
    {
        int number = 1;
        var root = new Tree($"Accpeted Candidates : {candidates.Count()}");

        foreach (var candidate in candidates)
        {
            var node = root.AddNode("Candidate").AddNode($"Number: [bold]{number}[/]");
            node.AddNode($"Full Name: [green bold]{candidate.FullName}[/]");

            var gender = candidate.Gender == 0 ? "Male" : "Female";

            node.AddNode($"Gender: [bold]{gender}[/]");
            
            node.AddNode($"Email: [bold]{candidate.Email}[/]");

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

            node.AddNode("Experience").AddNode(experienceTable);

            number++;
        }

        // Render the tree
        AnsiConsole.Write(root);
    }
}