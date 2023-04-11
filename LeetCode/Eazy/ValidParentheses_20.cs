using System.Collections.Generic;

namespace LeetCode.Eazy;

public class ValidParentheses_20
{
    private Stack<char> charsStack = new();
    private Dictionary<char, char> branches = new() {{'(', ')'}, {'[', ']'}, {'{', '}'}};
    
    public bool IsValid(string s) 
    {
        foreach (var sym in s)
        {
            if (branches.ContainsKey(sym))
            {
                charsStack.Push(sym);
                continue;
            }

            if (charsStack.Count == 0)
                return false;
            
            var prevSym = charsStack.Pop();
            if (branches[prevSym] != sym)
                return false;
        }

        return charsStack.Count == 0;
    } 
}