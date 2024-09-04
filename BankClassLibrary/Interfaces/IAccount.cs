using System;

namespace BankClassLibrary.Interfaces
{
    public interface IAccount
    {
        decimal Balance { get; }
        void Withdraw(decimal amount);
        void Deposit(decimal amount);
    }
}
