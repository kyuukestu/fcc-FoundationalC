string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

string message = "Dear ";
message += customerName;
message += ",\n";
message += $"As a custom of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.";
message += "\n\n";
message += $"Currently, you own {currentShares:C} shares at a return of {currentReturn:P2}.";
message += "\n\n";
message += $"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}";
message += "\n\n";

Console.WriteLine(message);
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = $"{currentProduct}\t\t{currentReturn:P2}\t{currentProfit:C}\n{newProduct}\t\t{newReturn:P2}\t{newProfit:C}";

Console.WriteLine(comparisonMessage);