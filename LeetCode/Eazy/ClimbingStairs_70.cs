namespace LeetCode.Eazy;

public class ClimbingStairs_70
{
    private int[] arr = new int[46];
    
    public int ClimbStairs(int n)
    {
        if (arr[n] != 0)
            return arr[n];
            
        for (var index = 0; index <= n; index++)
        {
            if (index == 0)
            {
                arr[index] = 1;
                continue;
            }

            if (index == 1)
            {
                arr[index] = 1;
                continue;
            }
            
            arr[index] = arr[index - 1] + arr[index - 2];
        }

        return arr[n];
    }
}