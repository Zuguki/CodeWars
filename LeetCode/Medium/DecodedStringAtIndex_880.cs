using System;
using System.Text;

namespace LeetCode.Medium;

public class DecodedStringAtIndex_880
{
    public string DecodeAtIndex(string s, int k)
    {
        var prev = 0;
        while (k > 0)
        {
            var length = 0;
            foreach (var sym in s)
            {
                prev = length;
                if (char.IsLetter(sym))
                {
                    length++;
                    if (length == k)
                        return sym.ToString();
                }
                else
                {
                    length *= int.Parse(sym.ToString());
                    if (length >= k)
                        k = 1 + (k - 1) % prev;
                }
            }
        }

        return "";
    }
    
    // public string DecodeAtIndex(string s, int k)
    // {
    //     var sb = new StringBuilder();
    //     var counter = 0;
    //     for (var index = 0; index < s.Length;)
    //     {
    //         var sym = s[index];
    //         if (char.IsLetter(sym))
    //         {
    //             var segment = GetNextSegment(index, s, char.IsLetter);
    //             counter += segment.Length;
    //             index += segment.Length;
    //             
    //             sb.Append(segment);
    //         }
    //         else if (char.IsDigit(sym))
    //         {
    //             var segment = GetNextSegment(index, s, char.IsDigit);
    //             index += segment.Length;
    //             var length = int.Parse(segment) - 1;
    //             var val = length * counter;
    //             k -= val;
    //         }
    //
    //         if (counter >= k)
    //             return sb.ToString()[k - 1].ToString();
    //     }
    //     
    //     return s;
    // }
    //
    // private string GetNextSegment(int index, string str, Func<char, bool> func)
    // {
    //     var sb = new StringBuilder();
    //     while (func(str[index]))
    //         sb.Append(str[index++]);
    //
    //     return sb.ToString();
    // }
}