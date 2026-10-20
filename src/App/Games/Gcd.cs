namespace App.Games;

public static class Gcd
{
    private const string Description = "Find the greatest common divisor of given numbers.";

    public static void Run() => Engine.Run(Description, GenerateRound);

    private static (string, string) GenerateRound()
    {
        var a = Random.Shared.Next(1, 101);
        var b = Random.Shared.Next(1, 101);
        return ($"{a} {b}", FindGcd(a, b).ToString());
    }

    private static int FindGcd(int a, int b) => b == 0 ? a : FindGcd(b, a % b);
}
