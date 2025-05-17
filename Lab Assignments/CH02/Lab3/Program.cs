// See https://aka.ms/new-console-template for more information

const double PERCENT_RAISE = 0.04;

//employee 1
Console.WriteLine("Enter employee 1:");
string name1 = Console.ReadLine();

Console.WriteLine("Enter {0} current salary:", name1);
double salary1_2018 = Convert.ToDouble(Console.ReadLine());


//employee 2
Console.WriteLine("Enter employee 2");
string name2 = Console.ReadLine();

Console.WriteLine("Enter {0} current salary:", name2);
double salary2_2018 = Convert.ToDouble(Console.ReadLine());

//employee 3
Console.WriteLine("Enter employee 3:");
string name3 = Console.ReadLine();

Console.WriteLine("Enter {0} current salary:", name3);
double salary3_2018 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Current 2018 Salary and Two Year Projected Raises");

// for year 2019

double salary1_2019 = salary1_2018 * (1 + PERCENT_RAISE);
double salary2_2019 = salary1_2018 * (1 + PERCENT_RAISE);
double salary3_2019 = salary1_2018 * (1 + PERCENT_RAISE);

//for year 2020
double salary1_2020 = salary1_2019 * (1 + PERCENT_RAISE);
double salary2_2020 = salary1_2019 * (1 + PERCENT_RAISE);
double salary3_2020 = salary1_2019 * (1 + PERCENT_RAISE);





Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("| Year  |  {0}         |  {1}           | {2}        |", name1, name2, name3);
Console.WriteLine("| 2018  |  {0:C}  |  {1:C}   | {2:C}  |", salary1_2018, salary2_2018, salary3_2018);
Console.WriteLine("| 2019  |  {0:C}  |  {1:C}   | {2:C}  |", salary1_2019, salary2_2019, salary3_2019);
Console.WriteLine("| 2020  |  {0:C}  |  {1:C}   | {2:C}  |", salary1_2020, salary2_2020, salary3_2020);


Console.WriteLine("--------------------------------------------------------------------------");



