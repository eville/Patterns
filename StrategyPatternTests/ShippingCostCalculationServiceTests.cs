using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern;

namespace StrategyPatternTests
{
    [TestClass]
    public class ShippingCostCalculationServiceTests
    {
        [TestMethod]
        public void WhenShipping_WithUPS_ReturnsCorrectCost()
        {
            //Arrange
            var expectedCost = 3.00d;
            var strategyUPS = new UPSShippingCostStrategy();
            var shippingCostCalculationService = new ShippingCostCalculationService(strategyUPS);
            var order = new Order();
            
            //Act
            var actualCost = shippingCostCalculationService.CalculateShippingCost(order);

            //Assert
            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void WhenShipping_WithFedex_ReturnsCorrectCost()
        {
            //Arrange
            var expectedCost = 5.00d;
            var strategyFedex = new FedexShppingCostStrategy();
            var shippingCostCalculationService = new ShippingCostCalculationService(strategyFedex);
            var order = new Order();

            //Act
            var actualCost = shippingCostCalculationService.CalculateShippingCost(order);

            //Assert
            Assert.AreEqual(expectedCost, actualCost);
        }

    }
}
