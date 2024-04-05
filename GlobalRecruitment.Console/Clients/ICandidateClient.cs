namespace GlobalRecruitment.Console.Clients;

public interface ICandidateClient
{
    Task<IEnumerable<Candidate>> GetCandidates();
}