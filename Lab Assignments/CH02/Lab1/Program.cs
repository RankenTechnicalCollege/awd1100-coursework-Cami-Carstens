// See https://aka.ms/new-console-template for more information

const double KM_PER_MILE = 1.6;

Console.Write("Please enter distance in miles: ");

string input = Console.ReadLine();

double miles = Convert.ToDouble(input);

double kilometers = miles * KM_PER_MILE;

Console.WriteLine("There are {0} miles in {1} kilometers", miles, kilometers);
