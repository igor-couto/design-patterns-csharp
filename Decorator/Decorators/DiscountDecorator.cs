namespace DesignPatterns.Decorator.Decorators;

public class DiscountDecorator : OrderDecorator
{
    private readonly double _discount;

    public DiscountDecorator(Order order, double discount) : base(order)
    {
        _discount = discount;
    }

    public override double CalculateTotal() => base.CalculateTotal() * (1 - _discount);
}