// See https://aka.ms/new-console-template for more information
//Arrays
string[] salesPerson = new string[3]
{ "Danielle", "Edward", "Francis"};
string[] salesInitials = { "D", "E",  "F"};
double[] salesTotals = new double[3];
int index = 0;

while (true)
{
    Console.WriteLine("Please enter the salesperson's initial. D for danielle.  E for Edward. or F for Francis. Or enter Z to finish!");
    string input = Console.ReadLine().ToUpper();

    if (input == "Z")
    {
        break;
    }
    if (input == "D")
        index = 0;
    else if (input == "E")
        index = 1;
    else if (input == "F")
        index = 2;
    else
    {
        Console.WriteLine("Invalid entry");
        continue;
    }
    //prompt for sale amount
    Console.WriteLine("How much was the sale?");
    if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
    {
        salesTotals[index] += amount;
    }
    else
    {
        Console.WriteLine("Invalid entry. Please try again.");
    }
}


//Find who is the top seller
double grandTotal = salesTotals[0] + salesTotals[1] + salesTotals[2];

int topSeller = 0; //assuming danielle starts higher sales, then compare to the other 2.
if (salesTotals[0] > salesTotals[topSeller]) topSeller = 0;
if (salesTotals[1] > salesTotals[topSeller]) topSeller = 1;
if(salesTotals[2] > salesTotals[topSeller]) topSeller = 2;

//display who is the top seller
string topResult = salesPerson[topSeller];
if(topSeller == 0)
{
    Console.WriteLine($"Top Seller is Danielle");
}
else if(topSeller == 1)
{
    Console.WriteLine($"Top Seller is Edward");
}
else
{
    Console.WriteLine($"Top Seller is Francis");
}

    //Display
    Console.WriteLine($"Current Sales Summary:");
    Console.WriteLine($"Danielle's Sales: ${salesTotals[0]:F2}");
    Console.WriteLine($"Edward' Sales: ${salesTotals[1]:F2}");
    Console.WriteLine($"Francis' Sales: ${salesTotals[2]:F2}");

Console.WriteLine($"Grand total sales: ${grandTotal:F2}");
Console.WriteLine($"Top seller: {topResult} with a total of ${salesTotals[topSeller]:F2}");







