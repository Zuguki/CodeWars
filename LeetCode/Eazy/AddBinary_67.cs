using System;
using System.Text;

namespace LeetCode.Eazy;

public class AddBinary_67
{
    public string AddBinary(string a, string b)
    {
        var res = new StringBuilder();
        var mind = false;
        if (a.Length < b.Length)
            a = a.PadLeft(b.Length, '0');
        else
            b = b.PadLeft(a.Length, '0');

        for (var index = a.Length - 1; index >= 0; index--)
        {
            if (a[index] == '1' && b[index] == '1')
            {
                if (mind)
                    res.Append('1');
                else
                    res.Append('0');
                mind = true;
            }
            else if ((a[index] == '0' && b[index] == '1') || (a[index] == '1' && b[index] == '0'))
            {
                if (mind)
                    res.Append('0');
                else
                    res.Append('1');
            }
            else
            {
                if (mind)
                    res.Append('1');
                else
                    res.Append('0');
                
                mind = false;
            }
        }

        if (mind)
            res.Append('1');

        return Reverse(res.ToString());
    }

    public static string Reverse( string s )
    {
        var charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}