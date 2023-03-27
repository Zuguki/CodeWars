using System;
using System.Collections.Generic;
using System.Linq;

namespace FourSum2
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    public class Solution {
        public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            var dict = new Dictionary<int, int>();
            var result = 0;

            foreach (var num1 in nums1)
            {
                foreach (var num2 in nums2)
                {
                    var sum = num1 + num2;
                    if (dict.ContainsKey(sum))
                        dict[sum]++;
                    else
                        dict.Add(sum, 1);
                }
            }

            foreach (var num3 in nums3)
            {
                foreach (var num4 in nums4)
                {
                    var sum = num3 + num4;
                    if (dict.TryGetValue(-sum, out var value))
                        result += value;
                }
            }

            return result;
        }
    }
}
