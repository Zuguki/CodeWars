using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Eazy;

public class KidsWithGreatestNumberOfCandies_1431
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var maxCandy = candies.Max();
        var result = new List<bool>(candies.Length);
        foreach (var candy in candies)
            result.Add((candy + extraCandies) >= maxCandy);

        return result;
    }
}