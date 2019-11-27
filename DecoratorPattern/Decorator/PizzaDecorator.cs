namespace DecoratorPattern
{
    public class PizzaDecorator : Pizza
    {
        Pizza pizza;
        public PizzaDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override double CalculateCost()
        {
            return pizza.CalculateCost();
        }

        public override string GetDescription()
        {
            return pizza.GetDescription();
        }
    }
}
