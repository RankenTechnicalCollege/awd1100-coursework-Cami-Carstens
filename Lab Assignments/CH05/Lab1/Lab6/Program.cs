// See https://aka.ms/new-console-template for more information

//Mr Gundmestad I know this extra credit is not going to count. 
//I messed with it for so long but never could get the table to line up right.




Console.WriteLine("How many rows should the table have?");
string row = Console.ReadLine();

if(!int.TryParse(row, out int rows)
    || rows <= 0) 
{
    Console.WriteLine("Invalid row number input. Try again.");
    return;
}
Console.WriteLine("How many columns should the table have?");
string column = Console.ReadLine();

if (!int.TryParse(column, out int columns)
    || columns <= 0)
{
    Console.WriteLine("Invalid column number input. Try again.");
    return;
}
//Things to remember. Console.WriteLine will add a line break. and mess up table structure if break isnt needed
Console.Write("|    |");

for (int c = 1; c <= columns; c++)
{
    Console.Write($" {c,3} |");
}


Console.WriteLine();

    Console.Write("|----|");
for (int c = 1; c <= columns; c++)
{
    Console.Write("----|");
}

 
Console.WriteLine();

//table
for (int r = 1; r < rows; r++)
{
    Console.Write($"| {r,2} |");

    for (int c = 1; c <= columns; c++)
    {
        Console.Write($" {r * c,3}  |");
    }

    Console.WriteLine();
      }

