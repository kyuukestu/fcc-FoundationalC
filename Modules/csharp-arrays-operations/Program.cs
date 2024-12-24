string[] pallets = ["B14", "A11", "B12", "A13"];

//SECTION - Sort an Array
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
//!SECTION

//SECTION - Reverse an Array
Console.WriteLine("\nReversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
//!SECTION

//SECTION - Clearing an Array
//ANCHOR -  Accessing the value of a clear element
Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count : {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
//!SECTION

//SECTION - Resize the Array

//ANCHOR - Adding a new items
Array.Resize(ref pallets, 6);
Console.WriteLine($"\nResizing 6 .. count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//ANCHOR - Removing a items
Array.Resize(ref pallets, 3);
Console.WriteLine($"\nResizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//!SECTION

//SECTION - Array operations on strings
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);

//ANCHOR - Array of Char to String
// string result = new string(valueArray);

//ANCHOR - Combine chars w/ comma-separated-value
string result = string.Join(",", valueArray);

Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
//!SECTION