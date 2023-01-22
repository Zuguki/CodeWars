namespace Sum_Of_Digits;

public abstract class Number
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
