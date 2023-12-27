namespace DesignPatterns.Decorator;

public abstract class Order
{
    public abstract string GetDescription();
    public abstract double CalculateTotal();
}