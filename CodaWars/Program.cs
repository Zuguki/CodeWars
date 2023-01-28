using System;
using System.Collections.Generic;
using CodaWars._5kuy;
using CodaWars._6kuy;
using CodaWars._8kuy;

static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (var item in collection)
        Console.Write(item);

    Console.WriteLine();
}