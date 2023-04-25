using System.Collections.Generic;

namespace LeetCode.Medium;

public class SmallestNumberInInfiniteSet_2336
{
    
}

// public class SmallestInfiniteSetV2
// {
//     private LinkedList<int> list;
//
//     public SmallestInfiniteSetV2()
//     {
//         list = new LinkedList<int>();
//     }
//
//     public int PopSmallest()
//     {
//         if (counter >= numbers.Length)
//             numbers = ResizeArray(numbers);
//
//         while (numbers[counter] != 0)
//         {
//             counter++;
//             if (counter >= numbers.Length)
//                 numbers = ResizeArray(numbers);
//         }
//
//         numbers[counter] = -1;
//         return counter++;
//     }
//
//     public void AddBack(int num)
//     {
//         if (!list.Contains(num))
//             list.A
//     }
//
//     private int[] ResizeArray(int[] arr)
//     {
//         var newArray = new int[arr.Length * 2];
//
//         for (var index = 0; index < arr.Length; index++)
//             newArray[index] = arr[index];
//
//         return newArray;
//     }
// }

public class SmallestInfiniteSet
{
    private HashSet<int> hashSet;
    private PriorityQueue<int, int> addedItems;
    private int counter;

    public SmallestInfiniteSet()
    {
        hashSet = new HashSet<int>();
        addedItems = new PriorityQueue<int, int>();
        counter = 1;
    }

    public int PopSmallest()
    {
        if (addedItems.Count > 0)
        {
            var item = addedItems.Dequeue();
            hashSet.Remove(item);
            return item;
        }

        return counter++;
    }

    public void AddBack(int num)
    {
        if (counter < num || hashSet.Contains(num))
            return;
        
        addedItems.Enqueue(num, num);
        hashSet.Add(num);
    }
}