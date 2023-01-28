namespace CodaWars._6kuy;

public abstract class SumOfDigits
{
    public static int DigitalRoot(long n)
    {
        var result = 0L;
        while (n > 0)
        {
            result += n % 10;
            n /= 10;
        }

        if (result >= 10)
            return DigitalRoot(result);

        return (int) result;
    }
}
