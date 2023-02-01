using System;
using System.Collections.Generic;
using CodaWars._4kuy;
using CodaWars._5kuy;

Console.WriteLine(HumanReadableDurationFormat.formatDuration(0));
Console.WriteLine(HumanReadableDurationFormat.formatDuration(15731080));
Console.WriteLine(HumanReadableDurationFormat.formatDuration(253374061));

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
