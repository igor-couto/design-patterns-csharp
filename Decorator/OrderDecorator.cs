namespace DesignPatterns.Decorator;

public abstract class OrderDecorator : Order
{
    protected Order _order;

    public OrderDecorator(Order order)
    {
        _order = order;
    }

    public override string GetDescription() => _order.GetDescription();

    public override double CalculateTotal() => _order.CalculateTotal();
}