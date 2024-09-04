using BankClassLibrary.Interfaces;
using System.Collections.Generic;

namespace BankClassLibrary;
public class Bank
{

    #region Properties
    public string Name { get; set; }
    public string Country { get; set; }
    public List<ICustomer> Customers { get; set; } = new List<ICustomer>();
    #endregion

    #region Constructor
    public Bank(string name, string country = null, List<ICustomer> customers = null)
    {
        Name = name;
        Country = country;
        if (customers != null) { Customers = customers; }
    }
    #endregion


    public override string ToString()
    {
        return $"This bank's name is {Name} and it resides in {Country}";
    }
}