using DesignPatterns.Adapter.Interfaces;
using DesignPatterns.Adapter.Services;

namespace DesignPatterns.Adapter;

public class PaymentServiceAdapter : IExistingPaymentService
{
    private readonly NewPaymentService _newPaymentService = new NewPaymentService();

    void ProcessCreditCard(string orderId, string cardNumber, float amount)
    {
        var transactionCode = Calcule(cardNumber);
        // Adapting the interface of NewPaymentService to IExistingPaymentService
        _newPaymentService.ExecuteTransaction(cardNumber, (decimal)amount, transactionCode);
    }

    // Some rule regarding the NewPaymentService
    private string CalculateTransactionNumber(string cardNumber)
    {
        if(cardNumber.Length > 3)
            return "TX00000";
        else 
            return "TX12345";    
    }
}