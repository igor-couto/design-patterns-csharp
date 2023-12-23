namespace DesignPatterns.Facade.Interfaces;

public interface IShippingService
{
    public void ArrangeShipping(string userId, string productId);
}