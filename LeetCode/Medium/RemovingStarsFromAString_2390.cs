using System.Text;

namespace LeetCode.Medium;

public class RemovingStarsFromAString_2390
{
    public string RemoveStars(string s)
    {
        var sb = new StringBuilder();

        foreach (var sym in s)
        {
            if (sym != '*')
                sb.Append(sym);
            else
                sb.Length--;
        }

        return sb.ToString();
    }
}