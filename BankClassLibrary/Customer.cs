using BankClassLibrary.Interfaces;
using System.Collections.Generic;

namespace BankClassLibrary;
public class Customer : ICustomer
{
    #region Properties
    public string Name { get; set; }
    public int CustomerNumber { get; set; }
    public List<IAccount> Accounts { get; set; } = new List<IAccount>();

    #endregion

    public Customer(string name, int customerNumber)
    {
        Name = name;
        CustomerNumber = customerNumber;
    }

    public decimal GetTotalBalanceAcrossAccounts()
    {
        decimal sum = 0;
        foreach (IAccount account in Accounts)
        {
            sum += account.Balance;
        }
        return sum;

        //oneliner using LINQ: return Accounts.Sum(acc => acc.Balance);
    }

    public override string ToString()
    {
        return $"This customer's name is {Name} and the customer's number is {CustomerNumber}. The customer has {Accounts.Count} accounts.";
    }
}