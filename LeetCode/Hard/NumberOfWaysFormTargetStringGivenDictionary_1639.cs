using System.Linq;

namespace LeetCode.Hard;

public class NumberOfWaysFormTargetStringGivenDictionary_1639
{
    public int NumWays(string[] words, string target)
    {
        var matrix = new int[words[0].Length, target.Length];
        var freq = new int[words[0].Length, 26];

        for (var i = 0; i < words[0].Length; i++)
        {
            for (var j = 0; j < target.Length; j++)
                matrix[i, j] = -1;
        }

        foreach (var word in words)
        {
            for (var j = 0; j < words[0].Length; j++)
            {
                var currentPos = word[j] - 'a';
                freq[j, currentPos]++;
            }
        }
        
        return NumWays(words, target, 0, 0, matrix, freq);
    }

    private int NumWays(string[] words, string target, int index, int letterIndex, int[,] matrix, int[,] freq)
    {
        if (letterIndex >= target.Length)
            return 1;
        if (words[0].Length == index)
            return 0;
        
        if (matrix[index, letterIndex] != -1)
            return matrix[index, letterIndex];

        var currentPos = target[letterIndex] - 'a';
        var counter = (long) NumWays(words, target, index + 1, letterIndex, matrix, freq);
        counter += (long) NumWays(words, target, index + 1, letterIndex + 1, matrix, freq) * freq[index, currentPos];
        counter %= 1000000007;

        matrix[index, letterIndex] = (int) counter;
        return (int) counter;
    }
}