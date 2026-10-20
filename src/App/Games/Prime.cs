namespace App.Games;

public static class Prime
{
    private const string Description =
        "Answer 'yes' if given number is prime. Otherwise answer 'no'.";

    public static void Run() => Engine.Run(Description, GenerateRound);

    private static (string, string) GenerateRound()
    {
        var number = Random.Shared.Next(1, 100);
        return (number.ToString(), IsPrime(number) ? "yes" : "no");
    }

    private static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (var i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
