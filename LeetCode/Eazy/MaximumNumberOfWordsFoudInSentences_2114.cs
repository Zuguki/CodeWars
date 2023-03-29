using System.Linq;

namespace LeetCode.Eazy;

public class MaximumNumberOfWordsFoudInSentences_2114
{
    public int MostWordsFound(string[] sentences) =>
        sentences.Select(str => str.Split(' ').Length)
            .Max();
}