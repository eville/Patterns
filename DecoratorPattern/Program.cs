using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Ham(largePizza);
            largePizza = new Peppers(largePizza);

            Console.WriteLine($"Pizza with toppings: {largePizza.GetDescription()}");
            Console.WriteLine($"Price {largePizza.CalculateCost()} Dollars");
        }
    }
}
