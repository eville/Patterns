using System;

namespace SimpleFactoryPattern
{
    public class Peugeot : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("Peugeot is turned off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Peugeot is turned on.");
        }
    }
}
