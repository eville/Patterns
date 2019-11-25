using System;

namespace SimpleFactoryPattern
{
    public class Renault : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Renault is turned off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Renault is turned on.");
        }
    }
}
