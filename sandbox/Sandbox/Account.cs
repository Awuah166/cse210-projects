using System;
using System.Security.Principal;

public class Account
{
    private string _accountId;
    private string _accountName;
    private string _accountType;
    private decimal _balance;
    private bool _isActive;

    public Account(string accountId, string acountName, string accountType)
    {
        _accountId = accountId;
        _accountName = acountName;
        _accountType = accountType;
    }

    public Account(string accountId, string acountName, string accountType, decimal initialBalance)
    {
        _accountId = accountId;
        _accountName = acountName;
        _accountType = accountType;
        _balance = initialBalance;
        _isActive = true;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0 && _isActive)
        {
            _balance += amount;
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive and account must be active.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= _balance && _isActive)
        {
            _balance -= amount;
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive, less than or equal to the balance, and account must be active.");
        }
    }

    public decimal GetBalance()
    {
        return _balance;
    }


    public void GetAccountInfo()
    {
        Console.WriteLine($"Account ID: {_accountId}");
        Console.WriteLine($"Account Name: {_accountName}");
        Console.WriteLine($"Account Type: {_accountType}");
        Console.WriteLine($"Balance: {_balance:C}");
        Console.WriteLine($"Status: {(_isActive ? "Active" : "Inactive")}");
    }

    public void DeactivateAccount()
    {
        _isActive = false;
    }
}