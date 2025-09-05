using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        // Asking the user for their first name
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        // Asking the user for their last name
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        // Displaying the users full name
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}