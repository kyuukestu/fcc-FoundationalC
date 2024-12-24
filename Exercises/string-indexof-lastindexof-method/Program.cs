string message = "hello there!";

int first_h = message.IndexOf("h");
int last_h = message.LastIndexOf("h");

Console.WriteLine($"Fore the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

//ANCHOR - Retrieve the last occurrence of a sub string
message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;

int closingPosition = message.LastIndexOf(')');

int length = closingPosition - openingPosition;

Console.WriteLine(message.Substring(openingPosition, length));

//ANCHOR - Retrieve all instances of substrings inside parentheses.

while (true)
{
    openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    closingPosition = message.IndexOf(')');
    length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining unprocessed message:
    message = message.Substring(closingPosition + 1);
}

//ANCHOR - Work with different types of symbol sets with IndexOfAny()

message = "Hello, world!";
char[] charsToFind = { 'a', 'e', 'i' };

// Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

//ANCHOR - Second Example
message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");

//ANCHOR - addendum
message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters.
// You want to look for:

openSymbols = ['[', '{', '('];

// You'll use a slightly different technique for iterating through the characters in the string. This time, use the closing position of the previous iteration as the starting index for the next open symbol. So, you need to initialize the closingPosition variable to zero:

closingPosition = 0;

while (true)
{
    openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify that the search for the matchingSymbol should start at the openingPosition in the string.

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}