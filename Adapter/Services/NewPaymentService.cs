using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter.Services;

public class NewPaymentService
{
    public void ExecuteTransaction(string accountNumber, decimal transactionAmount, string transactionCode)
    {
        // New way of processing payments with an additional transaction code parameter
        Console.WriteLine($"Executing transaction of {transactionAmount} using New Payment Service with account: {accountNumber}. Transaction Code: {transactionCode}");
    }
}
