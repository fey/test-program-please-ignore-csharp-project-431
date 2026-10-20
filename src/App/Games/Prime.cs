namespace App.Games;

public static class Prime
{
    private const string Description =
        "Answer 'yes' if given number is prime. Otherwise answer 'no'.";
    private const int MinNumber = 1;
    private const int MaxNumber = 100;

    public static void Run() => Engine.Run(Description, GenerateRound);

    private static (string, string) GenerateRound()
    {
        var number = Random.Shared.Next(MinNumber, MaxNumber + 1);
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
