using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter.Services;

public class ExistingPaymentService : IExistingPaymentService
{
    public void ProcessCreditCard(string orderId, string cardNumber, float amount)
    {
        // Implementation of credit card processing
        Console.WriteLine($"Order {orderId}: Processing {amount} using Existing Payment Service with card: {cardNumber}");
    }
}