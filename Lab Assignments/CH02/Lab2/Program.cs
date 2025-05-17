// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter test score #1:");
double Score1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter test score #2:");
double Score2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter test score #3:");
double Score3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter test score #4:");
double Score4 = Convert.ToDouble(Console.ReadLine());

double average = (Score1 + Score2 + Score3 + Score4) / 4;

Console.WriteLine("The average of these four test scores is {0}", average + "%");