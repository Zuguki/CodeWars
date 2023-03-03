using System;
using System.Collections.Generic;
using System.Linq;
using CodaWars._3kuy;
using CodaWars._4kuy;
using CodaWars._5kuy;

Console.WriteLine();

public static class EnumerableExt
{
    public static void PrintCollection<T>(this IEnumerable<T> collection)
    {
        Console.Write($"Items in collection: ");
        foreach (var item in collection)
            Console.Write(item + " ");

        Console.WriteLine();
    }

    public static void PrintDeepCollection<T>(this T[,] collection)
    {
        for (var row = 0; row < collection.GetLength(0); row++)
        {
            for (var column = 0; column < collection.GetLength(1); column++)
                Console.Write(collection[row, column]);
            
            Console.WriteLine();       
        }
    }
}
