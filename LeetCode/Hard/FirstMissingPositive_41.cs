using System;
using System.Collections.Generic;

namespace LeetCode.Hard;

public class FirstMissingPositive_41
{
    public int FirstMissingPositive(int[] nums)
    {
        var hashSet = new HashSet<int>(10_000);
        var maxValue = 0;

        foreach (var number in nums)
        {
            if (number < 1)
                continue;

            maxValue = Math.Max(maxValue, number);
            hashSet.Add(number);
        }

        for (var index = 1; index <= maxValue; index++)
        {
            if (!hashSet.Contains(index))
                return index;
        }

        return maxValue + 1;
    }
}