namespace CodaWars._8kuy;

public static class PriceOfMangoes
{
    public static int GetPriceForMango(int count, int price)
    {
        var freeMangoCount = count / 3;
        return (count - freeMangoCount) * price;
    }
}