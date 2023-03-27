Console.ReadKey();

public class Solution
{
    private Dictionary<char , List<string>> _letters;

    public Solution()
    {
        _letters = new Dictionary<char , List<string>>
        {
            {'2', new List<string> {"a", "b", "c"}},
            {'3', new List<string> {"d", "e", "f"}},
            {'4', new List<string> {"g", "h", "i"}},
            {'5', new List<string> {"j", "k", "l"}},
            {'6', new List<string> {"m", "n", "o"}},
            {'7', new List<string> {"p", "q", "r", "s"}},
            {'8', new List<string> {"t", "u", "v"}},
            {'9', new List<string> {"w", "x", "y", "z"}}
        };
    }

    public IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 1)
            return _letters[digits[0]];
        
        var parseDigits = GetParseLetters(digits);
        return new List<string>();
    }

    private Dictionary<char, List<string>> GetParseLetters(string digits) =>
        digits.ToDictionary(digit => digit, digit => _letters[digit]);
}