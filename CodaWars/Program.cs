using System;
using System.Collections.Generic;

DirectionsReduction.DirReduc(new[] {"NORTH", "WEST", "SOUTH", "EAST"}).PrintCollection();

public static class EnumerableExt
{
    public static void PrintCollection<T>(this IEnumerable<T> collection)
    {
        Console.Write($"Items in collection: ");
        foreach (var item in collection)
            Console.Write(item + " ");

        Console.WriteLine();
    }
}

// public static class StringExt
// {
//     public static IEnumerable<string> RepeatToArray(this string str, int count)
//     {
//         var result = new List<string>();
//         for (var index = 0; index < count; index++)
//             result.Add(str);
//
//         return result;
//     }
// }
