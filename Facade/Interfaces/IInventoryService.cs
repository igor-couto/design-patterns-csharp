namespace DesignPatterns.Facade.Interfaces;

public interface IInventoryService
{
    public void UpdateInventory(string productId, int quantity);
}