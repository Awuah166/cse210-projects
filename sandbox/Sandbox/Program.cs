using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");

        // Prompting the user for account details
        Console.Write("Enter Account ID: ");
        string accountId = Console.ReadLine();
        Console.Write("Enter Account Name: ");
        string accountName = Console.ReadLine();
        Console.Write("Enter Account Type (e.g., Savings, Checking): ");
        string accountType = Console.ReadLine();
        Console.Write("Enter Initial Balance: ");
        string initialBalance = Console.ReadLine();
        decimal initialBalanceDecimal = decimal.Parse(initialBalance);
        Console.WriteLine("How much would you like to withdraw? ");
        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
    
            Account account = new Account(accountId, accountName, accountType, initialBalanceDecimal);
            account.Withdraw(withdrawAmount);
            account.GetAccountInfo();
            Console.WriteLine($"Current Balance: {account.GetBalance():C}");

        // Creating an Account object



    }

    
}