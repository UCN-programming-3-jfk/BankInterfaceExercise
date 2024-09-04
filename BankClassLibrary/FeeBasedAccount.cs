using System;

namespace BankClassLibrary;
public class FeeBasedAccount : Account
{
    public const decimal FEE = .5M;
    public FeeBasedAccount(int balance) : base(balance) { }
    public override void Deposit(decimal amount) 
    {
        CheckSufficientBalanceForFee();
        base.Deposit(amount); 
    }

    public override void Withdraw(decimal amount)
    {
        CheckSufficientBalanceForFee();
        if (Balance < amount) { throw new ArgumentException("Not enough money for withdrawal") ; }
        Balance -= amount;
    }
    private void CheckSufficientBalanceForFee()
    {
        if (Balance < FEE)
        {
            throw new InsufficientFundsException($"You don't have enough funds to cover the {FEE} fee.");
        }
    }

    public override string ToString()
    {
        return base.ToString() + $" The fee to interact with this account is {FEE}";
    }
}