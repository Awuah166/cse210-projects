using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        // Create instances of MathAssignment and WritingAssignment and display their information
        MathAssignment mathAssignment = new MathAssignment("Dennis Awuah","Fractions","5.1", "1-10");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();
        WritingAssignment writingAssignment = new WritingAssignment("Dennis Awuah", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}