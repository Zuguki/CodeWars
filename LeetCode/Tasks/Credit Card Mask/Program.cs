using System;
using System.Numerics;

Console.ReadKey();

public static class Immortal
{
    public static bool Debug = false;

    public static long ElderAge(long rows, long columns, long time, long maxTime)
    {
        var platform = GetPlatform(rows, columns, time);
        return platform.Item2 % maxTime;
    }

    private static (long[][], long) GetPlatform(long rows, long columns, long time)
    {
        // var platform = new BigInteger[rows, columns];
        var platform = new long[rows][];
        var counter = 0L;
        for (var row = 0; row < rows; row++)
        {
            platform[row] = new long[columns];
            for (var column = 0; column < columns; column++)
            {
                platform[row][column] = time >= (row ^ column) ? 0 : (row ^ column) - time;
                counter += platform[row][column];
            }
        }

        return (platform, counter);
    }
}