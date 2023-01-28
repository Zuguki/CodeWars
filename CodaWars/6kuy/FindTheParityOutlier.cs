namespace CodaWars._6kuy;

public class FindTheParityOutlier
{
    public static int Find(int[] integers)
    {
        var oddNumber = 0;
        var evenNumber = 0;
        var evenNumberCounter = 0;
        foreach (var item in integers)
        {
            if (item % 2 == 0)
            {
                evenNumber = item;
                evenNumberCounter++;
            }
            else
                oddNumber = item;
        }

        return evenNumberCounter == 1 ? evenNumber : oddNumber;
    }
}