using System.Text;

namespace Simple_Pig_Latin;

public class Kata
{
    public static string PigIt(string str)
    {
        var words = str.Split(' ');
        var result = new StringBuilder();
        foreach (var word in words)
        {
            if (!char.IsLetter(word[0]))
            {
                result.Append(word);
                
                if (word != words[^1])
                    result.Append(' ');
                
                continue;
            }

            var substring = word[1..];
            result.Append(substring);
            result.Append(word[0]);
            result.Append("ay");
            
            if (word != words[^1])
                result.Append(' ');
        }

        return result.ToString();
    }
}