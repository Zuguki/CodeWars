using System;
using System.Text;

namespace LeetCode.Eazy;

public class MergeStringsAlternately_1768
{
    public string MergeAlternately(string word1, string word2)
    {
        var sb = new StringBuilder();
        
        for (var index = 0; index < Math.Max(word1.Length, word2.Length); index++)
        {
            if (index < word1.Length)
                sb.Append(word1[index]);
            if (index < word2.Length)
                sb.Append(word2[index]);
        }

        return sb.ToString();
    }
}