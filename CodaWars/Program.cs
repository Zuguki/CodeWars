using Unique_In_Order;

PrintCollection(Class1.UniqueInOrder("AAAABBBCCDAABBB"));

static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (var item in collection)
        Console.Write(item);

    Console.WriteLine();
}