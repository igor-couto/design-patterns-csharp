namespace DesignPatterns.Adapter.Interfaces;

public interface IExistingPaymentService
{
    void ProcessCreditCard(string orderId, string cardNumber, float amount);
}