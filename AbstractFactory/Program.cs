using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            IAutoFactory autofactory = LoadFactory(config);

            Console.WriteLine("ECONOMY CAR");
            var car = autofactory.CreateEconomyCar();
            car.TurnOn();
            car.TurnOff();

            Console.WriteLine("SPORTS CAR");
            car = autofactory.CreateSportsCar();
            car.TurnOn();
            car.TurnOff();

            Console.WriteLine("LUXURY CAR");
            car = autofactory.CreateLuxuryCar();
            car.TurnOn();
            car.TurnOff();
        }

        private static IAutoFactory LoadFactory(IConfiguration config)
        {
            var factoryName = config["autofactory"];
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}
