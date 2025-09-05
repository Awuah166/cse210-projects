using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // Asking the user for their exams score
        Console.Write("What is your exams score? ");
        string examScore = Console.ReadLine();
        int score = int.Parse(examScore);

        string letter = "";

        // Displaying their grade letter depending on their scores.
        if (score >= 90)
        {
            letter = "A";
        }

        else if (score >= 80)
        {
            letter = "B";
        }

        else if (score >= 70)
        {
            letter = "C";
        }

        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Creating a sign variable to determine if the get a "+" or "-"
        string sign = "";
        
        int scoreGrade = score % 10;
    
        if (scoreGrade >= 7)
        {
            sign = "+";
        }

        else if (scoreGrade >= 3)
        {
            sign = "-";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        else if (letter == "F" && sign == "-" || sign == "+")
        {
            sign = "";
        }
        Console.WriteLine($"You had {letter}{sign} grade");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations you passed the exams");
        }

        else
        {
            Console.WriteLine("Better luck next time");
        }
    }
}