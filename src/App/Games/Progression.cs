namespace App.Games;

public static class Progression
{
    private const string Description = "What number is missing in the progression?";
    private const int MinLength = 5;
    private const int MaxLength = 10;
    private const int MinStart = 1;
    private const int MaxStart = 50;
    private const int MinStep = 1;
    private const int MaxStep = 10;

    public static void Run() => Engine.Run(Description, GenerateRound);

    private static (string, string) GenerateRound()
    {
        var start = Random.Shared.Next(MinStart, MaxStart + 1);
        var step = Random.Shared.Next(MinStep, MaxStep + 1);
        var length = Random.Shared.Next(MinLength, MaxLength + 1);
        var hiddenIndex = Random.Shared.Next(length);

        var items = MakeProgression(start, step, length);
        var answer = items[hiddenIndex];
        items[hiddenIndex] = "..";

        return (string.Join(" ", items), answer);
    }

    private static string[] MakeProgression(int start, int step, int length)
    {
        var items = new string[length];
        for (var i = 0; i < length; i++)
        {
            items[i] = (start + i * step).ToString();
        }

        return items;
    }
}
