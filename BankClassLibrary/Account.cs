using BankClassLibrary.Interfaces;
using System;

namespace BankClassLibrary;
public class Account : IAccount
{
    public decimal Balance { get; protected set; }

    public Account(int balance)
    {
        Balance = balance;
    }
    public virtual void Deposit(decimal amount) { Balance += amount; }
    public virtual void Withdraw(decimal amount)
    {
        if (Balance < amount) { throw new ArgumentException("Not enough money for withdrawal") ; }
        Balance -= amount;
    }

    public override string ToString()
    {
        return $"This is an account of type {GetType().Name} and its current balance is {Balance}.";
    }
}