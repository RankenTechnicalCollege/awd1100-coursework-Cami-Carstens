// See https://aka.ms/new-console-template for more information
const decimal shirtPrice = 14.99m;
const decimal taxRate = 0.08m;


Console.WriteLine("Please enter your full name.");
string name = Console.ReadLine();

Console.WriteLine("Enter Street Address.");
string address = Console.ReadLine();

Console.WriteLine("Enter City");
string city  = Console.ReadLine();

Console.WriteLine("Enter State");
string state  = Console.ReadLine();

Console.WriteLine("Enter Zip Code");
string zipCode  = Console.ReadLine();

Console.WriteLine("Please enter quantity of shirts you would like to purchase.");
int shirtQuantity = Convert.ToInt32(Console.ReadLine());

decimal totalPrice = shirtQuantity * shirtPrice;
decimal salesTax = totalPrice * taxRate;
decimal amountDue = totalPrice + salesTax;


Console.WriteLine("Name: {0}", name);
Console.WriteLine("Street Address: {0}", address);
Console.WriteLine("City: {0}", city);
Console.WriteLine("State: {0}", state);
Console.WriteLine("Zip Code: {0}", zipCode);
Console.WriteLine("Shirt Quantity: {0}", shirtQuantity);
Console.WriteLine("----------------------------------------");
Console.WriteLine("Total Price: {0:C}", totalPrice);
Console.WriteLine("Sales Tax: {0:C}", salesTax);
Console.WriteLine("Amount Due: {0:C}", amountDue);




