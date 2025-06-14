// See https://aka.ms/new-console-template for more information
double subTotal = 0;
int numOfItems = 0;

const double TAX_RATE = 0.08;

while (true) //keeps asking for prices while true
{
    Console.WriteLine("Enter the item price. If you are finished with entries, please enter 0:");
    string input = Console.ReadLine();

    if (!double.TryParse(input, out double price))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        continue;
    }

    if (price == 0)//break out of loop/end loop
    {
        break;
    }
    else if (price < 0)
    {
        Console.WriteLine("Invalid input. Please enter a positive number.");
        continue;
    }
    else //after passing the above, now it will take in the users entries.
    {
        subTotal += price;
        numOfItems++;
    }
}
//Calculate
double averagePrice;
if (numOfItems > 0)
{
    averagePrice = subTotal / numOfItems;
}
else
{
    averagePrice = 0;
}


double totalTax = subTotal * TAX_RATE;
double grandTotal = subTotal + totalTax;

//results
Console.WriteLine($"Number of items purchased:{numOfItems}");
Console.WriteLine($"Average item prices: {averagePrice:C}");
Console.WriteLine($"Subtotal: {subTotal:C}");
Console.WriteLine($"Tax: {totalTax:C}"); 
Console.WriteLine($"Grand Total: {grandTotal:C}");




