void DisplayRandomNumbers()
{
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{random.Next(1, 11)}");
    }

    Console.WriteLine();
}

Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();