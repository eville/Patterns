namespace StrategyPattern
{
    public interface IShippingCostStrategy
    {
        double Calculate(Order order);
    }
}