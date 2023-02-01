using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodaWars._4kuy;

public class HumanReadableDurationFormat
{
    private static readonly string[] DurationSingular = {"year", "day", "hour", "minute", "second"};
    private static readonly string[] DurationPlural = {"years", "days", "hours", "minutes", "seconds"};
    
    public static string formatDuration(int seconds)
    {
        if (seconds == 0)
            return "now";

        var duration = GetDuration(seconds);
        var notZeroNumbersCount = duration.Count(item => item != 0);
        var notZeroNumberCounter = 0;
        var sb = new StringBuilder();
        for (var index = 0; index < duration.Length; index++)
        {
            if (duration[index] == 0)
                continue;

            notZeroNumberCounter += 1;
            sb.Append(duration[index]);
            sb.Append(" ");
            sb.Append(duration[index] == 1 ? DurationSingular[index] : DurationPlural[index]);

            if (notZeroNumbersCount - notZeroNumberCounter == 1)
                sb.Append(" and ");
            else if (notZeroNumbersCount - notZeroNumberCounter > 1)
                sb.Append(", ");
        }

        return sb.ToString();
    }

    private static int[] GetDuration(int seconds)
    {
        var minutes = seconds / 60;
        var hours = minutes / 60;
        var days = hours / 24;
        var years = days / 365;

        return new[] {years, days % 365, hours % 24, minutes % 60, seconds % 60};
    }
}