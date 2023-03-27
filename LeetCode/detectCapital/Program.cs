using System;
using System.Linq;

namespace detectCapital
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            Console.WriteLine(sol.DetectCapitalUse("USA"));
            Console.WriteLine(sol.DetectCapitalUse("FlaG"));
        }
    }
    
    public class Solution 
    {
        public bool DetectCapitalUse(string word) => word.Where(char.IsUpper).Count() == 1 && char.IsUpper(word[0])
                                                     || word.All(char.IsUpper)
                                                     || word.All(char.IsLower);
    }
}
