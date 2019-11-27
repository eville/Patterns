using System;

namespace StrategyPatternVariations
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Order, double> fedExStrategy = CalcForFedex;
            Func<Order, double> upsStrategy = delegate (Order order) { return 4.05d; };
            Func<Order, double> dhlStrategy = order =>  3.25d;

            var order = new Order();
            var calculateService = new ShippingCostCalculateService(fedExStrategy);
            Console.WriteLine($"Fedex Shipping Cost: {calculateService.CalculateShippingCost(order)}.");

            calculateService = new ShippingCostCalculateService(upsStrategy);
            Console.WriteLine($"UPS Shipping Cost: {calculateService.CalculateShippingCost(order)}.");

            calculateService = new ShippingCostCalculateService(dhlStrategy);
            Console.WriteLine($"DHL Shipping Cost: {calculateService.CalculateShippingCost(order)}.");

            Console.ReadKey();
        }

        internal static double CalcForFedex(Order order)
        {
            return 4.25d;
        }
    }
}
