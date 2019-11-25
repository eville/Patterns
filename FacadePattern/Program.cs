using System;
namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string zipCode = "LT-44311";

            var temperatureFacade = new TemperatureLookupFacade();
            var localTemp = temperatureFacade.GetTemperature(zipCode);

            Console.WriteLine(
                $"The current temperature is " +
                $"{localTemp.Farenheit}F/{localTemp.Celcius}C " +
                $"in {localTemp.City},{localTemp.Country}");
        }
    }
}
