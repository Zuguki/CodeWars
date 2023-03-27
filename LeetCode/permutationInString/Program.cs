using System;
using System.Collections.Generic;
using System.Linq;

namespace permutationInString
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            var ans = sol.CheckInclusion("abc", "ccccbbbbaaaa");
            Console.WriteLine(ans);
        }
    }
    
    public class Solution
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;

            var s1Hash = new int[26]; 
            var s2Hash = new int[26];

            for (var i = 0; i < s1.Length; i++)
            {
                s1Hash[s1[i] - 97]++;
                s2Hash[s2[i] - 97]++;
            }

            if (s1Hash.SequenceEqual(s2Hash)) 
                return true; 
            
            for (var i = s1.Length; i < s2.Length; i++)
            {   
                s2Hash[s2[i] - 97]++;
                s2Hash[s2[i - s1.Length] - 97]--;

                if(s1Hash.SequenceEqual(s2Hash))
                    return true; 
            }
            
            return false;
        }
    }
}
