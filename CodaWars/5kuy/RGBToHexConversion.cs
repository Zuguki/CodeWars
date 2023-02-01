using System;

namespace CodaWars._5kuy;

public class RGBToHexConversion
{
    public static string Rgb(int red, int green, int blue)
    {
        red = Math.Max(0, Math.Min(red, 255));
        green = Math.Max(0, Math.Min(green, 255));
        blue = Math.Max(0, Math.Min(blue, 255));

        return $"{red:X2}{green:X2}{blue:X2}";
    }
}