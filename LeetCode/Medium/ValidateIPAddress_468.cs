using System.Linq;

namespace LeetCode.Medium;

public class ValidateIPAddress_468
{
    public string ValidIPAddress(string queryIP)
    {
        if (IsValidIPv4(queryIP))
            return "IPv4";
        if (IsValidIPv6(queryIP))
            return "IPv6";

        return "Neither";
    }

    private bool IsValidIPv4(string str)
    {
        var items = str.Split('.');

        if (items.Length != 4)
            return false;

        if (items.Any(item => !item.IsDigit() || int.TryParse(item, out _) == false 
                                              || int.Parse(item) < 0 || int.Parse(item) > 255)) 
            return false;

        return true;
    }

    private bool IsValidIPv6(string str)
    {
        var items = str.Split(':');

        if (items.Length != 8)
            return false;

        if (items.Any(item => !item.IsHex() || item.Length is > 4 or 0))
            return false;

        return true;
    }
}

public static class StrExt
{
    public static bool IsDigit(this string str)
    {
        if (str.Length > 1 && str[0] == '0')
            return false;
        
        return int.TryParse(str, out _);
    }

    public static bool IsHex(this string str)
    {
        str = str.ToUpper();
        return str.All(sym => char.IsDigit(sym) || sym is 'A' or 'B' or 'C' or 'D' or 'E' or 'F');
    }
}
