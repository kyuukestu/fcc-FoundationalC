string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(' ');

for (int i = 0; i < words.Length; i++)
{
    char[] chars = words[i].ToCharArray();
    Array.Reverse(chars);

    // Console.WriteLine(chars);

    words[i] = new string(chars);
}

string result = string.Join(" ", words);
Console.WriteLine(result);
