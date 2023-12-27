namespace DesignPatterns.Decorator.Decorators;

public class PriorityHandlingDecorator : OrderDecorator
{
    public PriorityHandlingDecorator(Order order) : base(order) {}

    public override string GetDescription() => base.GetDescription() + " with Priority Handling";

    public override double CalculateTotal() => base.CalculateTotal() + 20.00; // Additional charge for priority handling
}