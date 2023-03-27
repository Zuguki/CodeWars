using System;
using System.Linq;

namespace canPlaceFlowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            Console.WriteLine(sol.CanPlaceFlowers(new [] {0}, 1));
        }
    }
    
    public class Solution {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            var emptyPlaceCounter = 0;

            for (var index = 0; index < flowerbed.Length; index++)
            {
                emptyPlaceCounter += SetToArray(GetCondition(flowerbed, index), flowerbed, index)
                    ? 1 : 0;
            }

            return emptyPlaceCounter >= n;
        }

        private bool SetToArray(bool condition, int[] array, int index)
        {
            if (!condition)
                return false;
            
            array[index] = 1;
            return true;
        }

        private bool GetCondition(int[] array, int index)
        {
            if (array.Length == 1)
                return array[index] == 0;
            
            if (index == 0)
                return array[0] == 0 && array[1] == 0;
            if (index == array.Length - 1)
                return array[index] == 0 && array[^2] == 0;
            return array[index - 1] == 0 && array[index] == 0 && array[index + 1] == 0;
        }
    }
}
