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
    private HashSet<int> removedItems;
    private SortedSet<int> addedItems;
    private int[] numbers;
    private int counter;

    public SmallestInfiniteSet()
    {
        removedItems = new HashSet<int>();
        addedItems = new SortedSet<int>();
        numbers = new int[2000];
        counter = 1;
    }

    public int PopSmallest()
    {
        if (counter >= numbers.Length)
            numbers = ResizeArray(numbers);

        if (addedItems.Count > 0)
        {
            var minItem = addedItems.Min;
            numbers[minItem] = -1;
            addedItems.Remove(minItem);
            return minItem;
        }
        
        numbers[counter] = -1;
        return counter++;
    }

    public void AddBack(int num)
    {
        if (numbers[num] == 0)
            return;
        
        numbers[num] = 0;
        addedItems.Add(num);
    }

    private int[] ResizeArray(int[] arr)
    {
        var newArray = new int[arr.Length * 2];

        for (var index = 0; index < arr.Length; index++)
            newArray[index] = arr[index];

        return newArray;
    }
}