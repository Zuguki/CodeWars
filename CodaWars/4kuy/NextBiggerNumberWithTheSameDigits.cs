using System;
using System.Collections.Generic;
using System.Linq;

namespace CodaWars._4kuy;

public static class NextBiggerNumberWithTheSameDigits
{
    public static long NextBiggerNumber(long number)
    {
        if (number / 10 == 0 || IsBiggestNumber(number))
            return -1;
        var needsNumber = long.MaxValue;

        foreach (var permutations in GetPermutation(number.ToString().ToCharArray(), 0, number.ToString().Length - 1)) 
        {
            var currentNumber = long.Parse(string.Join(null, permutations));
            if (currentNumber > number && currentNumber < needsNumber)
                needsNumber = currentNumber;
        }

        return needsNumber;
    }

    private static bool IsBiggestNumber(long number)
    {
        var previousNumber = int.MinValue;
        foreach (var item in number.ToString().Select(n => n.ToString()))
        {
            if (previousNumber != int.MinValue)
                if (int.Parse(item) > previousNumber)
                    return false;

            previousNumber = int.Parse(item);
        }

        return true;
    }

    public static IEnumerable<char[]> GetPermutation(char[] array, int fromBound, int length)
    {
        if (fromBound == length)
            yield return array;
        else
        {
            for(var index = fromBound; index <= length; index++)
            {
                (array[fromBound], array[index]) = (array[index], array[fromBound]);
                foreach (var chars in GetPermutation(array,fromBound + 1, length)) 
                    yield return chars;
                (array[fromBound], array[index]) = (array[index], array[fromBound]);
            }
        }
    }
}