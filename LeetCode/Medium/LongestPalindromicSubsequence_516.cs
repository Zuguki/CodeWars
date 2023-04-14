using System;

namespace LeetCode.Medium;

public class LongestPalindromicSubsequence_516
{
    public int LongestPalindromeSubseq(string s)
    {
        var matrix = new int[s.Length, s.Length];
        for (var i = 0; i < matrix.GetLength(0); i++)
            for (var j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = -1;
        
        return LPS(s, 0, s.Length - 1, matrix);
    }

    private int LPS(string str, int i, int j, int[,] matrix)
    {
        if (matrix[i, j] != -1)
            return matrix[i, j];
        
        if (i == j)
            return 1;
        if (i > j)
            return 0;

        if (str[i] == str[j])
            matrix[i, j] = 2 + LPS(str, i + 1, j - 1, matrix);
        else
            matrix[i, j] = Math.Max(LPS(str, i + 1, j, matrix), LPS(str, i, j - 1, matrix));
        
        return matrix[i, j];
    }
}