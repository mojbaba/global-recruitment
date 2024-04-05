using Spectre.Console;

namespace GlobalRecruitment.Console.Services;

public class ExperienceRequirementSelector(IEnumerable<Technology> technologies)
{
    public IEnumerable<Experience> SelectExperienceRequirements()
    {
        AnsiConsole.Clear();
        
        var selectedTechnologies = AnsiConsole.Prompt(
            new MultiSelectionPrompt<Technology>()
                .Title("What are your [green]desired technologies[/]?")
                .NotRequired() // Not required to have a favorite fruit
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more technologies)[/]")
                .InstructionsText(
                    "[grey](Press [blue]<space>[/] to toggle a technology, " +
                    "[green]<enter>[/] to accept)[/]")
                .AddChoices(technologies.ToArray())
        );

        var selectedExperiences = new List<Experience>();

        var table = new Table()
            .RoundedBorder()
            .AddColumn("Technology")
            .AddColumn("Years");

        foreach (var technology in selectedTechnologies)
        {
            var years = AnsiConsole.Ask<int>($"How many years of experience do you require for [green bold]{technology.Name}[/]?");

            table.AddRow(technology.Name, years.ToString());
            
            selectedExperiences.Add(new Experience
            {
                TechnologyId = technology.Guid,
                YearsOfExperience = years
            });
        }

        AnsiConsole.Render(table);

        if (!AnsiConsole.Confirm("Are you sure about your selection?"))
        {
            return SelectExperienceRequirements();
        }

        return selectedExperiences;
    }
}