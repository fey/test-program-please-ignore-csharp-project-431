namespace App.Games;

public static class Progression
{
    private const string Description = "What number is missing in the progression?";
    private const int MinLength = 5;
    private const int MaxLength = 10;

    public static void Run() => Engine.Run(Description, GenerateRound);

    private static (string, string) GenerateRound()
    {
        var start = Random.Shared.Next(1, 50);
        var step = Random.Shared.Next(1, 10);
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
