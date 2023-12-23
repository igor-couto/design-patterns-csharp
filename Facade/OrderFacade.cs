using DesignPatterns.Facade.Interfaces;
using DesignPatterns.Facade.Services;

namespace DesignPatterns.Facade;

public class OrderFacade
{
    private readonly IInventoryService _inventoryService = new InventoryService();
    private readonly IPaymentService _paymentService = new PaymentService();
    private readonly IShippingService _shippingService = new ShippingService();

    public bool PlaceOrder(string userId, string productId, int quantity, decimal amount)
    {
        if (!_paymentService.ProcessPayment(userId, amount)) 
            return false;

        _inventoryService.UpdateInventory(productId, quantity);
        _shippingService.ArrangeShipping(userId, productId);
        return true;
    }
}
