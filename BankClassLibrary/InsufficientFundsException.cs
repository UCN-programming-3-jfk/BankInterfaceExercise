using System;
namespace BankClassLibrary;
public class InsufficientFundsException : ApplicationException
{
    public InsufficientFundsException(string message, Exception innerException = null) : base (message, innerException)
    {
    }
}