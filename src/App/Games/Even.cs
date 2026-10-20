namespace App.Games;

public static class Even
{
    private const string Description =
        "Answer \"yes\" if the number is even, otherwise answer \"no\".";

    public static void Run() => Engine.Run(Description, GenerateRound);

    private static (string, string) GenerateRound()
    {
        var number = Random.Shared.Next(1, 100);
        return (number.ToString(), IsEven(number) ? "yes" : "no");
    }

    private static bool IsEven(int number) => number % 2 == 0;
}
