using DesignPatterns.Facade.Interfaces;

namespace DesignPatterns.Facade.Services;

public class PaymentService : IPaymentService
{
    public bool ProcessPayment(string userId, decimal amount) 
    {
        // Code to process payment
        return true;
    }
}