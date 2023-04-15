using System;
using System.Collections.Generic;

namespace LeetCode.Hard;

public class MaximumValueOfKCoinsFromPiles_2218
{
    public int MaxValueOfCoins(IList<IList<int>> piles, int k)
    {
        if (k <= 0)
            return 0;

        var matrix = new int[k + 1, piles.Count];
        for (var i = 0; i <= k; i++)
            for (var j = 0; j < piles.Count; j++)
                matrix[i, j] = -1;

        return MaxValueOfCoins(piles, 0, k, matrix);
    }

    private int MaxValueOfCoins(IList<IList<int>> piles, int currentIndex, int k, int[,] matrix)
    {
        if (k <= 0 || currentIndex >= piles.Count)
            return 0;
        if (matrix[k, currentIndex] != -1)
            return matrix[k, currentIndex];

        var coinsCount = piles[currentIndex].Count;
        var maxMoneyPick = Math.Min(k, coinsCount);

        var result = MaxValueOfCoins(piles, currentIndex + 1, k, matrix);

        var pickSum = 0;
        for (var index = 0; index < maxMoneyPick; index++)
        {
            pickSum += piles[currentIndex][index];
            var temp = MaxValueOfCoins(piles, currentIndex + 1, k - index - 1, matrix);
            result = Math.Max(result, pickSum + temp);
        }

        matrix[k, currentIndex] = result;
        return result;
    }
}