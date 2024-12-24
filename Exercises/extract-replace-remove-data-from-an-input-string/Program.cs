const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

string openSpan = "<span>";
string endSpan = "</span>";
string openDiv = "<div>";
string endDiv = "</div>";

quantity = input.Substring((input.IndexOf(openSpan) + openSpan.Length), input.IndexOf(endSpan) - (input.IndexOf(openSpan) + openSpan.Length));

output = input.Replace("&trade;", "&reg;");
output = output.Remove(output.IndexOf(openDiv), openDiv.Length);
output = output.Remove(output.IndexOf(endDiv), endDiv.Length);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");