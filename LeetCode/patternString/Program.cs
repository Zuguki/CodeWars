using System;
using System.Collections.Generic;
using System.Linq;

namespace patternString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    public class Solution {
        public bool WordPattern(string pattern, string str) 
        {
            var words = str.Split(' ');

            return pattern.Length == words.Length && UniqueMapping(pattern, words) && UniqueMapping(words, pattern);

            static bool UniqueMapping<T1, T2>(IEnumerable<T1> x, IEnumerable<T2> y)
                => x.Zip(y).GroupBy(p => p.First).All(g => g.Distinct().Count() == 1);
        }
    }
}
