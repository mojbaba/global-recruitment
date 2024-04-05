namespace GlobalRecruitment.Console;

public record Candidate
{
    public string CandidateId { get; init; }
    public string FullName { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Gender { get; init; }
    public string ProfilePicture { get; init; }
    public string Email { get; init; }
    public string FavoriteMusicGenre { get; init; }
    public string Dad { get; init; }
    public string Mom { get; init; }
    public bool CanSwim { get; init; }
    public string Barcode { get; init; }
    public List<Experience> Experience { get; init; }
}

public record Experience
{
    public string TechnologyId { get; init; }
    public int YearsOfExperience { get; init; }
}
