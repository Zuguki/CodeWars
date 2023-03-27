using System;

namespace subarraySumEqualsK
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
        public int SubarraySum(int[] nums, int k)
        {
            var total = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                var totalCount = nums[i];

                if (totalCount == k)
                    total++;

                for (var j = i + 1; j < nums.Length; j++)
                {
                    totalCount += nums[j];

                    if (totalCount == k) 
                        total++;
                }
            }

            return total;
        }
    }
}
