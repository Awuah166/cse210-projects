using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        // Asking the user for a list of numbers
        Console.WriteLine("Enter a list of numbers, Enter 0 when finished: ");

        // Creating a list to store the numbers
        List<int> numbers = new List<int>();
        int sum = 0;
        while (true)
        {
            Console.Write("Enter Number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            numbers.Add(number);
            sum += number;
            if (number == 0)
            {
                break;
            }

        }
        // Calculatin the total of the numbers
        Console.WriteLine($"The total is: {sum}");

        // Calculating the average of the numbers
        double average = (double)sum / (numbers.Count - 1);
        Console.WriteLine($"The average is: {average}");

        // Displaying the largest number
        int largest = numbers.Take(numbers.Count - 1).Max();
        Console.WriteLine($"The largest nnumbe is: {largest}");
    }
}