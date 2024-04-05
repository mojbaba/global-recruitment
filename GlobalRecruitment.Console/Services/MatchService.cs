using GlobalRecruitment.Console.Clients;

namespace GlobalRecruitment.Console.Services;

public class MatchService(ITechnologyClient technologyClient, ICandidateClient candidateClient)
{
    private IEnumerable<Technology> _cachedTechnologies;

    public async Task<List<Candidate>> GetMatchedCandidatesAsync(IEnumerable<Experience> technologyExperiences)
    {
        var technologies = (_cachedTechnologies ??= await technologyClient.GetTechnologiesAsync());
        var candidates = await candidateClient.GetCandidatesAsync();
        
        var matchingCandidates = candidates
            .Where(candidate => technologyExperiences.All(technologyExperience =>
                candidate.Experience.Any(candidateExperience =>
                    candidateExperience.TechnologyId == technologyExperience.TechnologyId &&
                    candidateExperience.YearsOfExperience >= technologyExperience.YearsOfExperience)))
            .ToList();

        return matchingCandidates;
    }
}