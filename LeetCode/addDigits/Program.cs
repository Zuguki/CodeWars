using System;

namespace addDigits
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
        public int AddDigits(int num)
        {
            var sum = 0;
            
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum < 10 ? sum : AddDigits(sum);
        }
    }
}
