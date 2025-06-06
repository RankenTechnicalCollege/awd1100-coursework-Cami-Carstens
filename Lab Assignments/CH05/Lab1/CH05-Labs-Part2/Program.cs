// See https://aka.ms/new-console-template for more information

using System.Xml.Schema;

List <int> scoresInput = new List<int>();
const int highestCount = 999;
int sum = 0;



while(true) //loop to keep asking for score
{
    Console.WriteLine("Please enter a test score 0-100. Or enter 999 to finish.");
       string input = Console.ReadLine();

    if (int.TryParse(input, out int score))
    {
        if (score == highestCount)
        {
            break; //stops loop when 999 is entered
        }

        else if (score >= 0 && score <= 100)
        {
            scoresInput.Add(score); //put a score into list
        }
        else
        {
            Console.WriteLine("Invalid score. Please enter a score between 0-100.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a whole number.");
    }
    }


//Calculate

if (scoresInput.Count > 0)
{
    int min = int.MaxValue;
    int max = int.MinValue;

    foreach (int score in scoresInput)
    {
        sum += score;
       if (score < min) 
            min = score;
       if (score > max) 
            max = score;
    }

    //display
    double averageScore = (double)sum / scoresInput.Count;
    Console.WriteLine($"Scores: {scoresInput.Count}");
    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Average Score: {averageScore:F2}");
    Console.WriteLine($"Minimum Score: {min}");
    Console.WriteLine($"Maximum Score: {max}");
}





