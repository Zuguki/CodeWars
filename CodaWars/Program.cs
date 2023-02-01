using System;
using System.Collections.Generic;
using CodaWars._5kuy;

Console.WriteLine(RGBToHexConversion.Rgb(255, 255, 255));
Console.WriteLine(RGBToHexConversion.Rgb(255, 255, 300));
Console.WriteLine(RGBToHexConversion.Rgb(0, 0, 0));
Console.WriteLine(RGBToHexConversion.Rgb(148, 0, 211));

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
