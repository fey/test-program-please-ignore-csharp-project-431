namespace App.Games;

public static class Calc
{
    private const string Description = "What is the result of the expression?";
    private static readonly char[] Operators = ['+', '-', '*'];

    public static void Run() => Engine.Run(Description, GenerateRound);

    private static (string, string) GenerateRound()
    {
        var a = Random.Shared.Next(1, 20);
        var b = Random.Shared.Next(1, 20);
        var op = Operators[Random.Shared.Next(Operators.Length)];
        return ($"{a} {op} {b}", Calculate(a, b, op).ToString());
    }

    private static int Calculate(int a, int b, char op) =>
        op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            _ => throw new ArgumentException($"Unknown operator: {op}"),
        };
}
