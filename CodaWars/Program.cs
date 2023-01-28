using System;
using System.Collections.Generic;
using Sum_Of_Digits;

Console.WriteLine(Number.DigitalRoot(16));
Console.WriteLine(Number.DigitalRoot(942));
Console.WriteLine(Number.DigitalRoot(132189));
Console.WriteLine(Number.DigitalRoot(493193));

static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (var item in collection)
        Console.Write(item);

    Console.WriteLine();
}