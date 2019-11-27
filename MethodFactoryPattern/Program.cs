using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace MethodFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            
            IAutoFactory autofactory = LoadFactory(config);

            var car = autofactory.CreateAutomobile();

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
