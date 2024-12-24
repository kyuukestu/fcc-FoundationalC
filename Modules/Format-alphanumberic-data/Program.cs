//ANCHOR - Formatting text.
string first = "Hello";
string second = "World";

string result = string.Format("{0} {1}", first, second);

Console.WriteLine(result);

Console.WriteLine("{0} {1}", first, second);
Console.WriteLine("{0} {1}", first, first);

Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

//ANCHOR - Formatting Currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

//ANCHOR - Formatting numbers
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

Console.WriteLine($"Measurement: {measurement:N4} units");


//ANCHOR - Formatting Percentages
decimal tax = 0.36785m;
Console.WriteLine($"Tax: {tax:P2}");

decimal secPrice = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price", (secPrice - salePrice), secPrice);
yourDiscount += $"A discount of {((secPrice - salePrice) / secPrice):P2}!"; //inserted
Console.WriteLine(yourDiscount);


//ANCHOR - Number formatting exercise
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = 0.15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"\t Share: {productShares:N3} Product");
Console.WriteLine($"\t\t Sub Total: {subtotal:C}");
Console.WriteLine($"\t\t\t Tax: {taxPercentage:P2}");
Console.WriteLine($"\t\t Total Billed: {total:C}");

//ANCHOR - Padding
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));

Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));


string paymentID = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);