Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(0, 6);
        var roll = random.Next(0, 6);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? readResult;
    bool validEntry = true;

    readResult = Console.ReadLine();
    readResult = readResult.ToLower();

    validEntry = readResult == "y" || readResult == "n" ? true : false;

    while (validEntry == false)
    {
        Console.WriteLine("Invalid entry. Input \"Y\" or \"N\".");
        readResult = Console.ReadLine();
        readResult = readResult.ToLower();
    }

    return readResult == "y";
}

string WinOrLose(int roll, int target)
{
    return roll > target ? "win" : "lose";
}