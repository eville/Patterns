namespace StrategyPattern
{
    public class ShippingCostCalculationService
    {
        private readonly IShippingCostStrategy shippingCostStrategy;

        public ShippingCostCalculationService(IShippingCostStrategy shippingCostStrategy)
        {
            this.shippingCostStrategy = shippingCostStrategy;
        }

        public double CalculateShippingCost(Order order)
        {
            return shippingCostStrategy.Calculate(order);
        }
    }
}
