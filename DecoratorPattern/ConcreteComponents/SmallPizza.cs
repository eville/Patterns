using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class SmallPizza : Pizza
    {
        public SmallPizza()
        {
            Description = "Small Pizza";
        }
        public override double CalculateCost()
        {
            return 3.00;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
