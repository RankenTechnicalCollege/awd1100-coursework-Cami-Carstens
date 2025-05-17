// See https://aka.ms/new-console-template for more information

const double DAILY_RATE = 100.00;
const double MILE_RATE = 0.50;

Console.WriteLine("How many days have you been traveling?");
int days = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many miles have you traveled?");
double miles = Convert.ToDouble(Console.ReadLine());

double total = (days * DAILY_RATE) + (miles * MILE_RATE);

Console.WriteLine("You total rental fee is: {0}", total.ToString("F"));

