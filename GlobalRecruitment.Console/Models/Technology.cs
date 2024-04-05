namespace GlobalRecruitment.Console;

public record Technology
{
    public string Name { get; set; }
    public string Guid { get; set; }

    public override string ToString() => Name;
}