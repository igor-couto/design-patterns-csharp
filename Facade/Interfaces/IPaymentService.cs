namespace DesignPatterns.Facade.Interfaces;

public interface IPaymentService
{    
    public bool ProcessPayment(string userId, decimal amount);
}