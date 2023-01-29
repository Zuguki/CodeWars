using System;
using System.Collections.Generic;
using CodaWars._5kuy;
using CodaWars._6kuy;
using CodaWars._8kuy;

Console.WriteLine(HumanReadableTime.GetReadableTime(0));
Console.WriteLine(HumanReadableTime.GetReadableTime(5));
Console.WriteLine(HumanReadableTime.GetReadableTime(60));
Console.WriteLine(HumanReadableTime.GetReadableTime(86399));
Console.WriteLine(HumanReadableTime.GetReadableTime(359999));

static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (var item in collection)
        Console.Write(item);

    Console.WriteLine();
}