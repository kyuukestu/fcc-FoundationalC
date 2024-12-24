int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"Global Statement: {a} x {b} = {c}");

void Multiply(int x, int y, int z)
{
    c = a * b;
    Console.WriteLine($"Inside Multiply method: {a} x {b} = {c}");
}

int[] array = { 1, 2, 3, 4, 5 };

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
    foreach (int a in array)
    {
        Console.Write($"{a}");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}

string status = "Healthy";

Console.WriteLine($"Start: {status}");
// SetHealth(status, false);
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy, string status = "Healthy")
{
    status = (isHealthy ? "Healthy" : "UNhealthy");
    Console.WriteLine($"Middle: {status}");
}