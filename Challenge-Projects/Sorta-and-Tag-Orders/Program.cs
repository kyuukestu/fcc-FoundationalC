//TODO - Parse the individual "Order IDs", and output the "OrderIDs" sorted and tagged as "Error" if they aren't exactly four characters in length.

string orderSteam = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderSteam.Split(',');
Array.Sort(orders);

for (int i = 0; i < orders.Length; i++)
{
    if (orders[i].Length != 4)
    {
        Console.WriteLine($"{orders[i]} - Error");
    }
    else
    {
        Console.WriteLine($"{orders[i]}");
    }
}