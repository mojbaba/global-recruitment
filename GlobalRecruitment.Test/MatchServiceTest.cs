using GlobalRecruitment.Console;
using GlobalRecruitment.Console.Services;

namespace GlobalRecruitment.Test;

public class MatchServiceTest
{
    [Fact]
    public async Task GetMatchedCandidatesAsync_WhenCalled_ReturnsMatchingCandidates()
    {
        // Arrange
        var technologyClient = new MockedTechnologyClient();
        var candidateClient = new MockedCandidateClient();
        var matchService = new MatchService(await technologyClient.GetTechnologiesAsync(), candidateClient);

        var technologyExperiences = new List<Experience>
        {
            new Experience { TechnologyId = "3B85BE83-9B4E-4B15-9EB2-68363936CA14", YearsOfExperience = 1 },
            new Experience { TechnologyId = "3B85BE83-9B4E-4B15-9EB2-68363936CA11", YearsOfExperience = 1 }
        };

        // Act
        var result = await matchService.GetMatchedCandidatesAsync(technologyExperiences);

        // Assert
        Assert.Equal(1, result.Count);
        Assert.Equal("b4e7f105-0cff-467a-bb3f-8b5a5c9f839d", result[0].CandidateId);
        Assert.Equal("Lula Moen", result[0].FullName);
        
    }
}