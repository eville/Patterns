using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza) : base(pizza)
        {
            Description = "Cheese";
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 1.25;
        }
    }
}
