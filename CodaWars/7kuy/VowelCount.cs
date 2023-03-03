using System.Collections.Generic;
using System.Linq;

namespace CodaWars._7kuy;

public static class VowelCount
{
    private static List<char> vowels = new() {'a', 'e', 'i', 'o', 'u'};
    
    public static int GetVowelCount(string str)
    {
        return str.Count(item => vowels.Any(sym => sym == item));
    } 
}