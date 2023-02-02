using System;

namespace CodaWars._3kuy;

public class MakeSpiral
{
    public static int[,] Spiralize(int size)
    {
        var array = new int[size, size];
        var currentPosition = (0, 0);
        var indent = 0;

        while (true)
        {
            var previousPosition = currentPosition;
            currentPosition = GoToTop(array, currentPosition, indent);
            currentPosition = GoToRight(array, currentPosition, indent);
            currentPosition = GoToDown(array, currentPosition, indent);
            currentPosition = GoToLeft(array, currentPosition, indent);

            indent += 2;
            
            if (previousPosition == currentPosition)
                break;
        }

        return array;
    }

    private static (int, int) ChangeArrayState(IWalker walker, int[,] area, (int, int) currentPosition, int indent)
    {
        return walker.GoTo(area, currentPosition, indent);
    }

    private static (int, int) GoToTop(int[,] area, (int, int) currentPosition, int indent)
    {
        if (currentPosition.Item1 < indent || (currentPosition.Item1 - 1 >= 0 &&
                                               currentPosition.Item2 + 1 < area.GetLength(0) &&
                                               area[currentPosition.Item1 - 1, currentPosition.Item2 + 1] != 0)) 
            return currentPosition;
        
        while (currentPosition.Item1 >= indent)
            area[currentPosition.Item1--, currentPosition.Item2] = 1;
        
        currentPosition.Item1++;
        return currentPosition;
    }

    private static (int, int) GoToDown(int[,] area, (int, int) currentPosition, int indent)
    {
        if (currentPosition.Item1 >= area.GetLength(0) - indent ||
            (currentPosition.Item1 + 1 < area.GetLength(0) && currentPosition.Item2 - 1 < 0 &&
             area[currentPosition.Item1 + 1, currentPosition.Item2 - 1] != 0))
            return currentPosition;
        
        while (currentPosition.Item1 < area.GetLength(0) - indent)
            area[currentPosition.Item1++, currentPosition.Item2] = 1;

        currentPosition.Item1--;
        return currentPosition;
    }

    private static (int, int) GoToRight(int[,] area, (int, int) currentPosition, int indent)
    {
        if (currentPosition.Item2 >= area.GetLength(1) - indent ||
            (currentPosition.Item1 + 1 < area.GetLength(1) && currentPosition.Item2 + 1 < area.GetLength(1) &&
             area[currentPosition.Item1 + 1, currentPosition.Item2 + 1] != 0))
            return currentPosition;
        
        while (currentPosition.Item2 < area.GetLength(1) - indent)
            area[currentPosition.Item1, currentPosition.Item2++] = 1;

        currentPosition.Item2--;
        return currentPosition;
    }
    
    private static (int, int) GoToLeft(int[,] area, (int, int) currentPosition, int indent)
    {
        if (currentPosition.Item2 < indent || (currentPosition.Item1 - 1 >= 0 && currentPosition.Item2 >= 0 &&
                                               area[currentPosition.Item1 - 1, currentPosition.Item2 - 1] != 0))
            return currentPosition;
        
        while (currentPosition.Item2 >= indent)
            area[currentPosition.Item1, currentPosition.Item2--] = 1;

        currentPosition.Item2++;
        return currentPosition;
    }
}

public interface IWalker
{
    (int, int) GoTo(int[,] area, (int, int) currentPosition, int indent);
}

public class UpWalker : IWalker
{
    public (int, int) GoTo(int[,] area, (int, int) currentPosition, int indent)
    {
        if (currentPosition.Item1 < indent)
            return currentPosition;
        
        while (currentPosition.Item1 >= indent)
            area[currentPosition.Item1--, currentPosition.Item2] = 1;
        
        currentPosition.Item1++;
        return currentPosition;
    }
}

public class DownWalker : IWalker
{
    public (int, int) GoTo(int[,] area, (int, int) currentPosition, int indent)
    {
        if (currentPosition.Item1 >= area.GetLength(0) - indent)
            return currentPosition;
        
        while (currentPosition.Item1 < area.GetLength(0) - indent)
            area[currentPosition.Item1++, currentPosition.Item2] = 1;

        currentPosition.Item1--;
        return currentPosition;
    }
}

public class RightWalker : IWalker
{
    public (int, int) GoTo(int[,] area, (int, int) currentPosition, int indent)
    {
        if (currentPosition.Item2 >= area.GetLength(1) - indent)
            return currentPosition;
        
        while (currentPosition.Item2 < area.GetLength(1) - indent)
            area[currentPosition.Item1, currentPosition.Item2++] = 1;

        currentPosition.Item2--;
        return currentPosition;
    }
}

public class LeftWalker : IWalker
{
    public (int, int) GoTo(int[,] area, (int, int) currentPosition, int indent)
    {
        if (currentPosition.Item2 < indent)
            return currentPosition;
        while (currentPosition.Item2 >= indent)
            area[currentPosition.Item1, currentPosition.Item2--] = 1;

        currentPosition.Item2++;
        return currentPosition;
    }
}
