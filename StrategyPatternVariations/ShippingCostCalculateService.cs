using System;

namespace StrategyPatternVariations
{
    internal class ShippingCostCalculateService
    {
        private Func<Order, double> strategy;

        public ShippingCostCalculateService(Func<Order, double> strategy)
        {
            this.strategy = strategy;
        }

        public double CalculateShippingCost(Order order)
        {
            return this.strategy(order);
        }
    }
}