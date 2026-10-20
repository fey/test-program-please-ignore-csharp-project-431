using App;
using App.Games;

Console.WriteLine("Please enter the game number and press Enter.");
Console.WriteLine("1 - Greet");
Console.WriteLine("2 - Even");
Console.WriteLine("3 - Calc");
Console.WriteLine("0 - Exit");
Console.Write("Your choice: ");
var choice = Console.ReadLine();
Console.WriteLine();

switch (choice)
{
    case "1":
        Cli.Greet();
        break;
    case "2":
        Even.Run();
        break;
    case "3":
        Calc.Run();
        break;
}
