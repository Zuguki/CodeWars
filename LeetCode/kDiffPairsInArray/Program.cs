using System;
using System.Collections.Generic;

namespace kDiffPairsInArray
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            var nums = new[] {1,2,4,4,3,3,0,9,2,3};
            var k = 3;

            Console.WriteLine(sol.FindPairs(nums, k));
        }
    }
    
    public class Solution
    {
        public int FindPairs(int[] nums, int k)
        {
            var pairs = new List<(int, int)>();

            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k 
                        && !pairs.Contains((nums[i], nums[j])) && !pairs.Contains((nums[j], nums[i])))
                        pairs.Add((nums[i], nums[j]));
                }
            }

            return pairs.Count;
        }
    }
}
