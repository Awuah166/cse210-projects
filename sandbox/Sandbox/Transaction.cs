using System;
using System.ComponentModel;
using System.IO.Compression;

public class Transaction
{
    private string _transactionId;
    private DateTime _date;
    private decimal _amount;
    private string _description;
    private string _category;
    private string _accountId;
    private string _transactionType; // "Credit" or "Debit"

    public Transaction(string transactionId, DateTime date, decimal amount, string description, string category, string accountId, string transactionType)
    {
        _transactionId = transactionId;
        _date = date;
        _amount = amount;
        _description = description;
        _category = category;
        _accountId = accountId;
        _transactionType = transactionType;
    }

    public string GetTransactionInfo()
    {
        return $"Transaction ID: {_transactionId}\nDate: {_date.ToShortDateString()}\nAmount: {_amount:C}\nDescription: {_description}\nCategory: {_category}\nAccount ID: {_accountId}\nType: {_transactionType}";
    }

    public void UpdateDescription(string newDescription)
    {
        _description = newDescription;
    }

    public void IsExpense()
    {
        if (_transactionType.ToLower() == "debit")
        {
            Console.WriteLine("This transaction is an expense.");
        }
        else
        {
            Console.WriteLine("This transaction is not an expense.");
        }
    }

    public void IsIncome()
    {
        if (_transactionType.ToLower() == "credit")
        {
            Console.WriteLine("This transaction is income.");
        }
        else
        {
            Console.WriteLine("This transaction is not income.");
        }
    }
}