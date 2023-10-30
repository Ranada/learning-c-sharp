void Divider()
{
    string divider = "\n";

    int i = 0;
    while (i < 100)
    {
        divider += "-";
        i++;
    }

    Console.WriteLine(divider);
}

Console.WriteLine("Initializing and accessing array elements");

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// fraudelentOrderIDs[3] = "D000";

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


Divider();

int[] inventory = { 200, 450, 700, 175, 250 };

int bin = 0;
int sum = 0;
foreach (int items in inventory)
{
    bin++;
    sum += items;
    Console.WriteLine($"Bin {bin} = {items}. Running total = {sum}.");
}

Console.WriteLine($"We have {sum} items in the inventory.");

Divider();

string[] IDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

Console.WriteLine("Suspicious IDs that start with 'B'");
foreach (string ID in IDs)
{
    if (ID.StartsWith("B"))
    {
        Console.WriteLine(ID);
    }
}
