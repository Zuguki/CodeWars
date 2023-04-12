using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Medium;

public class SimplifyPath_71
{
    public string SimplifyPath(string path)
    {
        var stack = new Stack<string>();
        var correctPath = path.Replace("//", "/").TrimEnd('/');
        var sb = new StringBuilder();

        foreach (var item in correctPath.Split('/', StringSplitOptions.RemoveEmptyEntries))
        {
            if (stack.Count == 0 && item == ".." || item == ".")
                continue;
            
            if (item == "..")
                stack.Pop();
            else
                stack.Push(item);
        }

        var lastItem = stack.Count > 0 ? stack.Peek() : null;
        sb.Append("/");
        foreach (var item in stack.Reverse())
        {
            sb.Append(item);
            if (item != lastItem)
                sb.Append("/");
        }

        return sb.ToString();
    }
}