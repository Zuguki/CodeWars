using System;
using System.Linq;

namespace findTheDifference
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    public class Solution 
    {
        public char FindTheDifference(string s, string t) => t.First(letter => !s.Contains(letter) 
                                                                               || t.Count(let => let == letter) 
                                                                               > s.Count(c => c == letter));
    }
}
