namespace App;

public static class Engine
{
    public const int RoundsCount = 3;

    public static void Run(string description, Func<(string Question, string Answer)> generateRound)
    {
        var name = Cli.Greet();
        Console.WriteLine(description);

        for (var i = 0; i < RoundsCount; i++)
        {
            var (question, correctAnswer) = generateRound();
            Console.WriteLine($"Question: {question}");
            Console.Write("Your answer: ");
            var answer = Console.ReadLine() ?? string.Empty;

            if (answer != correctAnswer)
            {
                Console.WriteLine(
                    $"'{answer}' is wrong answer ;(. Correct answer was '{correctAnswer}'."
                );
                Console.WriteLine($"Let's try again, {name}!");
                return;
            }

            Console.WriteLine("Correct!");
        }

        Console.WriteLine($"Congratulations, {name}!");
    }
}
