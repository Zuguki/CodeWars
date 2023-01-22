using System.Text;

namespace Duplicate_Encoder;

public class Kata
{
    public static string DuplicateEncode(string word)
    {
        var wordInLower = word.ToLower();
        var result = new StringBuilder();
        var lettersCount = new Dictionary<char, int>();

        foreach (var letter in wordInLower)
        {
            if (!lettersCount.ContainsKey(letter))
                lettersCount.Add(letter, 0);
            
            lettersCount[letter]++;
        }

        foreach (var letter in wordInLower)
            result.Append(lettersCount[letter] == 1 ? "(" : ")");

        return result.ToString();
    }
}