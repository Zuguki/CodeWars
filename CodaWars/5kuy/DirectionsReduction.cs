using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class DirectionsReduction
{
    private static readonly Dictionary<string, int> Sides = new()
        {{"NORTH", 1}, {"SOUTH", -1}, {"WEST", 2}, {"EAST", -2}};

    public static string[] DirReduc(string[] array)
    {
        var stack = new Stack<string>();
        
        foreach (var item in array)
        {
            if (stack.Count == 0)
                stack.Push(item);
            else
            {
                var peek = stack.Peek();
                if (Sides[peek] + Sides[item] != 0)
                    stack.Push(item);
                else
                    stack.Pop();
            }
        }

        return stack.Reverse().ToArray();
    }
}

