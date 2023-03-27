using System;
using System.Text;

namespace palindromNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.IsPalindrome(121));
            Console.WriteLine(Solution.IsPalindrome(-121));
            Console.WriteLine(Solution.IsPalindrome(263));
        }
    }

    public static class Solution 
    {
        public static bool IsPalindrome(int x) 
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            var reversedNumber = 0;
            var number = x;
            
            while (number > 0)
            {
                reversedNumber *= 10;
                reversedNumber += number % 10;
                number /= 10;
            }

            return reversedNumber == x;
        }
    }
}
