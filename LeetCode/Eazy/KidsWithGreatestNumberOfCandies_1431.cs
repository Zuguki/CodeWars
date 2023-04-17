using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Eazy;

public class KidsWithGreatestNumberOfCandies_1431
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var mostBeGreaterThan = candies.Max() - extraCandies;
        return candies.Select(candy => candy >= mostBeGreaterThan).ToList();
    }
}