using System.Collections.Generic;

namespace BankClassLibrary.Interfaces
{
    public interface ICustomer
    {
        public string Name { get; set; }
        public int CustomerNumber { get; set; }
        public List<IAccount> Accounts { get; set; }
        public decimal GetTotalBalanceAcrossAccounts();
    }
}