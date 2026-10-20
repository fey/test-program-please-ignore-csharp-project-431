namespace App.Games;

public static class Gcd
{
    private const string Description = "Find the greatest common divisor of given numbers.";
    private const int MinNumber = 1;
    private const int MaxNumber = 100;

    public static void Run() => Engine.Run(Description, GenerateRound);

    private static (string, string) GenerateRound()
    {
        var a = Random.Shared.Next(MinNumber, MaxNumber + 1);
        var b = Random.Shared.Next(MinNumber, MaxNumber + 1);
        return ($"{a} {b}", FindGcd(a, b).ToString());
    }

    private static int FindGcd(int a, int b) => b == 0 ? a : FindGcd(b, a % b);
}
