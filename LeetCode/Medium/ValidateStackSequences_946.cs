using System.Collections.Generic;

namespace LeetCode.Medium;

public class ValidateStackSequences_946
{
    public bool ValidateStackSequences(int[] pushed, int[] popped)
    {
        var pushIndex = 0;
        var popIndex = 0;
        var stack = new Stack<int>();

        while (popIndex != popped.Length)
        {
            if (pushIndex >= pushed.Length && stack.Count > 0 && stack.Peek() != popped[popIndex])
                return false;
            
            if (stack.Count > 0 && stack.Peek() == popped[popIndex])
            {
                stack.Pop();
                popIndex++;
            }
            else if (pushIndex < pushed.Length)
                stack.Push(pushed[pushIndex++]);
        }

        return true;
    }
}