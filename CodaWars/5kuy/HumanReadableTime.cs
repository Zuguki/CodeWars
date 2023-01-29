namespace CodaWars._5kuy;

public class HumanReadableTime
{
    public static string GetReadableTime(int seconds) =>
        $"{seconds / 3600:d2}:{seconds / 60 % 60:d2}:{seconds % 60:d2}";
}