using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Ham : PizzaDecorator
    {
        public Ham(Pizza pizza) : base(pizza)
        {
            Description = "Ham";
        }
        public override string GetDescription()
        {
            return $"{base.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 1.00;
        }
    }
}
