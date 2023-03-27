using System;
using System.Collections.Generic;
using System.Linq;

namespace singleNumber
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
        public int SingleNumber(int[] nums)
        {
            var numsDict = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (numsDict.ContainsKey(num))
                    numsDict[num]++;
                else
                    numsDict.Add(num, 1);
            }

            return numsDict.First(item => item.Value == 1).Key;
        }
    }
}
