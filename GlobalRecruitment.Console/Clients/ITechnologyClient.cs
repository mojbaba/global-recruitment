namespace GlobalRecruitment.Console.Clients;

public interface ITechnologyClient
{
    Task<IEnumerable<Technology>> GetTechnologiesAsync();
}