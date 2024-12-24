string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string internalDomain = "contoso.com";
string externalDomain = "hayworth.com";


// display internal email addresses
Console.WriteLine($"Internal Employees: ");
CreateEmail(corporate, internalDomain);

//display external email addresses
Console.WriteLine($"\nExternal Employees: ");
CreateEmail(external, externalDomain);

void CreateEmail(string[,] names, string domain)
{
    string[] email = new string[names.GetLength(0)];

    // Console.WriteLine($"{names.GetLength(0)} employees; {names.GetLength(1)} names");

    for (int i = 0; i < names.GetLength(0); i++)
    {
        for (int j = 0; j < names.GetLength(1); j++)
        {
            email[i] = $"{names[i, 0].Substring(0, 2).ToLower()}{names[i, 1].ToLower()}@{domain}";
        }
    }

    foreach (string mail in email)
    {
        Console.WriteLine(mail);
    }
}
