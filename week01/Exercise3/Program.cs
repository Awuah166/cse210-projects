using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string keepPlaying = "yes";
        while (keepPlaying == "yes")
        {
            // Generating a random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int attempts = 0;

            // Creating a while loop to keep asking the user for a guess until they get it right
            while (guess != magicNumber)
            {
                // Asking the user for their guess
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);
                attempts += 1;
                // Creating an if statement to check if the user needs to guess higer or lower
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {attempts} attempts.");
                }
            }
            // Asking the user if they want to play again
            Console.Write("Do you want to play again? (yes/no) ");
            keepPlaying = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Thank you for playing!");
    }
}