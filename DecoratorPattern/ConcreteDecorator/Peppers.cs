namespace DecoratorPattern
{
    public class Peppers : PizzaDecorator
    {
        public Peppers(Pizza pizza): base(pizza)
        {
            Description = "Peppers";
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 2.00;
        }
    }
}
