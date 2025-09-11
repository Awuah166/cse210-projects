using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        // Create an instance of Journal
        Journal myJournal = new Journal();
        myJournal._entries = new List<Entry>();

        // Create an instance of PromptGenerator
        PromptGenerator promptGen = new PromptGenerator();
        promptGen._prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new I learned today?"
        };

        // Create an instance of Entry
        

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                // Create an instance of Entry
                Entry entry = new Entry();
                entry._promptText = promptGen.GetRandomPrompt();
                entry._date = DateTime.Now.ToShortDateString();
                entry._entryText = "";


                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                myJournal.AddEntry(entry);
            }

            else if (userChoice == "2")
            {
                myJournal.DisplayAll();
            }

            else if (userChoice == "3")
            {
                myJournal.LoadFromFile();
            }

            else if (userChoice == "4")
            {
                myJournal.SaveToFile();
            }

            else if (userChoice == "5")
            {
                break; // Exit the loop and end the program
            }

            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
    
}