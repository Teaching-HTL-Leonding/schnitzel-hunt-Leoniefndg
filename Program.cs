const string Schnitzel = "Schnitzel"; string menuPath = @"C:\HTL\Htl cooding\076.Schnitzel_hunt\MenuCards"; string[] lines;
string food;
string price;
System.Console.WriteLine("Where to get Scnitzel?");
System.Console.WriteLine("======================");

string[] CardDirectory = Directory.GetFiles(menuPath);

for (int i = 0; i < CardDirectory.Length; i++)
{
    string restaurantName = CardDirectory[i];
    int y = restaurantName.LastIndexOf(@"\");
    y = y + 1;
    string z = restaurantName.Substring(0, y);
    restaurantName = restaurantName.Replace(z, "");
    restaurantName = restaurantName.Replace(".txt", "");

    lines = File.ReadAllLines(CardDirectory[i]);
    for (int l = 0; l < lines.Length; l++)
    {
        if (lines[l].Contains(Schnitzel))
        {
            System.Console.WriteLine(restaurantName);
            System.Console.WriteLine($"    {lines[l]}");
        }
    }
}
void SplitIt(string[] CardDirectory, out string food, out string price)
{
    food = "";
    price = "";
    for (int i = 0; i < CardDirectory.Length; i++)
    {
        lines = File.ReadAllLines(CardDirectory[i]);
        string[] splittedLines = lines[i].Split(":");

        food = splittedLines[0];
        price = splittedLines[1];

    }
}
System.Console.WriteLine("Where to get the cheapest Saitan Schnitzel");
for (int i = 0; i < CardDirectory.Length; i++)
{
    SplitIt(CardDirectory, out food, out price);

    int priceInNumbers = int.Parse(price);
    lines = File.ReadAllLines(CardDirectory[i]);

    for (int l = 0; l < lines.Length; l++)
    {
        if (lines.Contains("Saitan Schnitzel"))
        {
         
        }
    }
}
