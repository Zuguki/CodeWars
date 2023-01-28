namespace CodaWars._6kuy;

public static class WhoLikesIt
{
    public static string Likes(string[] names) =>
        names.Length switch
        {
            0 => "no one likes this",
            1 => $"{names[0]} likes this",
            2 => $"{names[0]} and {names[1]} like this",
            3 => $"{names[0]}, {names[1]} and {names[2]} like this",
            _ => $"{names[0]}, {names[1]} and {names.Length - 2} others like this"
        };
}