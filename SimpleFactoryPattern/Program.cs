namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = args[0];

            var factory = new AutoFactory();

            IAuto car = factory.CreateInstance(carName);

            car.TurnOn();

            car.TurnOff();
        }
    }
}
