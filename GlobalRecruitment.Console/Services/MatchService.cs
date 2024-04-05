using GlobalRecruitment.Console.Clients;

namespace GlobalRecruitment.Console.Services;

public interface IMatchService
{
    Task<List<Candidate>> GetMatchedCandidatesAsync(IEnumerable<Experience> technologyExperiences);
}

public class MatchService(IEnumerable<Technology> technologies, ICandidateClient candidateClient) : IMatchService 
{
    private IEnumerable<Technology> _cachedTechnologies;

    public async Task<List<Candidate>> GetMatchedCandidatesAsync(IEnumerable<Experience> technologyExperiences)
    {
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