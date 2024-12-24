// string input = "snake";
// string inputSentence = "Ekans is snake backwards";

// Console.WriteLine(input);
// Console.WriteLine(ReverseWord(input));
// Console.WriteLine(ReverseSentence(inputSentence));

// string ReverseWord(string word)
// {
//     string result = "";

//     for (int i = word.Length - 1; i >= 0; i--)
//     {
//         result += word[i];
//     }

//     return result;
// }

// string ReverseSentence(string input)
// {
//     string result = "";

//     string[] sentence = input.Split(" ");

//     for (int i = 0; i < sentence.Length; i++)
//     {
//         sentence[i] = ReverseWord(sentence[i]);
//     }

//     result = String.Join(" ", sentence);

//     return result;
// }

Console.WriteLine(!(true && false));