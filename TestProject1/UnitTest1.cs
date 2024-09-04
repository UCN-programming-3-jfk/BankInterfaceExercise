using BankClassLibrary;
using BankClassLibrary.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;
namespace TestProject1;
public class Tests
{
    [Test]
    public void TestGettingBalancesAccrossAcounts()
    {
        decimal correctSum = 2800;

        //ARRANGE
        IAccount account1 = new Account(-200);
        IAccount account2 = new Account(500);
        IAccount account3 = new Account(2500);
        ICustomer customer = new Customer("Janet", 42) { Accounts = new List<IAccount> { account1, account2, account3 } };

        //ACT
        decimal sum = customer.GetTotalBalanceAcrossAccounts();
        
        //ASSERT
        Assert.That(correctSum, Is.EqualTo(sum), "The counted sum was incorrect");
    }
}