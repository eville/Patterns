namespace StrategyPattern
{
    public class FedexShppingCostStrategy: IShippingCostStrategy
    {
        public double Calculate(Order order)
        {
            return 5.00d;
        }
    }
}
