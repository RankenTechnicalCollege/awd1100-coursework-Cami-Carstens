// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter 1 real number of your choice");
double num1 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Please enter another real number of your choice");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter one more real number of your choice");
double num3 = Convert.ToDouble(Console.ReadLine());

double numAverage = (num1 + num2 + num3) / 3;

Console.WriteLine("The average of these numbers is {0:F2}", numAverage);