namespace DesignPatterns.Decorator;

public class StandardOrder : Order
{
    private const double _standardBasePrice = 100.00;
    public override string GetDescription() => "Standard Order";

    public override double CalculateTotal() => _standardBasePrice;
}