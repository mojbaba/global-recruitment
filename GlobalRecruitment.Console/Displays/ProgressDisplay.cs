namespace GlobalRecruitment.Console.Services;

public class ProgressDisplay
{
    public static void DisplayProgress(int current, int total)
    {
        System.Console.Write($"\r{current}/{total}");
    }
}