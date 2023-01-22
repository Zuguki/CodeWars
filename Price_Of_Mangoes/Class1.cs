namespace Price_Of_Mangoes;

public static class Class1
{
    public static int GetPriceForMango(int count, int price)
    {
        var freeMangoCount = count / 3;
        return (count - freeMangoCount) * price;
    }
}